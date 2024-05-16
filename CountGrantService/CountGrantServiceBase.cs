using GrantApp.Models;
using GrantApp.Data;

namespace GrantApp.Services
{
  public class CountGrantServiceBase : ICountGrantService
  {
    DataContextDapper _dapper;
    public CountGrantServiceBase(IConfiguration config)
    {
      _dapper = new DataContextDapper(config);
    }
    public async Task<int> CountGrant(IEnumerable<Rating> ratesData, decimal budget, decimal minGrant)
    {
      Dictionary<int, decimal> rates = new Dictionary<int, decimal>();
      decimal leadingAdd = 1.00m;

      foreach (Rating rating in ratesData)
      {
        if (rating.Leads) rates.Add(rating.Student, rating.Scores + leadingAdd);
        else rates.Add(rating.Student, rating.Scores);
      }

      decimal sumRates = 0;

      foreach (var rate in rates)
      {
        sumRates += rate.Value;
      }

      if (budget / rates.Count < minGrant)
      {
        return 0;
      }

      foreach (var rate in rates)
      {
        if (rate.Value > sumRates / 3)
        {
          rates[rate.Key] = sumRates / 3;
        }
      }

      decimal payForPoint = budget / sumRates;

      Dictionary<int, decimal> grants = rates.ToDictionary(
        kv => kv.Key,
        kv => kv.Value * payForPoint
        );

      decimal needed = 0;

      if (payForPoint * rates.First().Value < minGrant)
      {
        System.Console.WriteLine("Считаю....");
        decimal minPoints = minGrant / payForPoint;

        decimal norm = minPoints * 2 - rates.First().Value;

        foreach (var rate in rates)
        {
          rates[rate.Key] = (rate.Value + norm) / 2;
        }

        foreach (var rate in rates)
        {
          needed += rate.Value * payForPoint;
        }

        grants = rates.ToDictionary(
        kv => kv.Key,
        kv => kv.Value * payForPoint
        );

        if (needed > budget)
        {
          int countNotMin = grants.Where(kvp => kvp.Value > minGrant).Count();
          decimal overage = needed - budget;

          while (overage > 0)
          {
            decimal overageSplit = overage / countNotMin;

            foreach (var grant in grants)
            {
              if (grant.Value > minGrant)
              {
                if (grant.Value - overageSplit < minGrant)
                {
                  overage -= grant.Value - minGrant;
                  grants[grant.Key] = minGrant;
                  countNotMin--;
                }

                else
                {
                  overage -= overageSplit;
                  grants[grant.Key] -= overageSplit;
                }
              }
            }
          }
        }
      }

      int finalSum = 0;
      foreach (var grant in grants)
      {
        finalSum += (int)grant.Value;
      }

      string sql = "DELETE FROM ac_database.grants;";
      await _dapper.ExecuteSqlAsync(sql);

      foreach (var grant in grants)
      {
        sql = "INSERT INTO ac_database.grants(ID, amount, updated) VALUES (" + grant.Key + ", " + (int)grant.Value
        + ", CURRENT_TIMESTAMP());";
        await _dapper.ExecuteSqlAsync(sql);
      }

      foreach (var grant in grants)
      {
        Console.WriteLine($"Id: {grant.Key}, стипендия: {(int)grant.Value}");
      }
      Console.WriteLine(finalSum);

      return (int)finalSum;
    }
  }
}