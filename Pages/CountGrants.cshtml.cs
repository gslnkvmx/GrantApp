using GrantApp.Data;
using GrantApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GrantApp.Services;

namespace GrantApp.Pages;

[Authorize]
public class CountGrantsModel : PageModel
{
  private readonly ICountGrantService countGrantService;
  DataContextDapper _dapper;
  public int? Amount { get; set; }
  public IEnumerable<Rating> ratingsList = [];
  public IEnumerable<GrantDTO> grantsList = [];
  public string ErrorMessage { get; set; } = "";
  public DateTime? lastUpdated;
  public CountGrantsModel(IConfiguration config)
  {
    _dapper = new DataContextDapper(config);
    this.countGrantService = new CountGrantServiceBase(config);
  }

  public void OnGet()
  {

  }

  public async Task<IActionResult> OnPost()
  {
    string sql = @"SELECT * FROM ac_database.rating ORDER BY rating.scores;";

    ratingsList = _dapper.LoadData<Rating>(sql);

    Amount = await countGrantService.CountGrant(ratingsList, Convert.ToDecimal(Request.Form["budget"]),
     Convert.ToDecimal(Request.Form["minGrant"]));
    if (Amount == 0)
    {
      ErrorMessage = "Невозможно рассчитать стипендию с заданными условиями!";
      return Page();
    }

    sql = @"SELECT concat_ws(' ', last_name, first_name, middle_name) AS full_name, amount, updated, scores as Score
      FROM ac_database.students JOIN ac_database.grants 
      ON students.id = grants.ID
      JOIN ac_database.rating
      ON students.id = rating.student
      ORDER BY grants.amount DESC;";
    grantsList = _dapper.LoadData<GrantDTO>(sql);
    System.Console.WriteLine(grantsList.First().Score);
    lastUpdated = grantsList.First().Updated;

    return Page();
  }
}
