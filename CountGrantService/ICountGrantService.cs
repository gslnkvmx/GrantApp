using GrantApp.Models;

namespace GrantApp.Services
{
  public interface ICountGrantService
  {
    public Task<int> CountGrant(IEnumerable<Rating> ratesData, decimal budget, decimal minGrant);
  }
}