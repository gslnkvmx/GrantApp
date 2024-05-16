using GrantApp.Data;
using GrantApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GrantApp.Services;

namespace GrantApp.Pages;

[Authorize]
public class GrantsTableModel : PageModel
{
  private readonly ICountGrantService countGrantService;
  DataContextDapper _dapper;
  public IEnumerable<GrantDTO> grantsList = [];
  public string ErrorMessage { get; set; } = "";
  public DateTime? lastUpdated;
  public GrantsTableModel(IConfiguration config)
  {
    _dapper = new DataContextDapper(config);
    this.countGrantService = new CountGrantServiceBase(config);
  }

  public void OnGet()
  {
    try
    {
      string sql = @"SELECT concat_ws(' ', last_name, first_name, middle_name) AS full_name, amount, updated, scores as Score
      FROM ac_database.students JOIN ac_database.grants 
      ON students.id = grants.ID
      JOIN ac_database.rating
      ON students.id = rating.student
      ORDER BY Score DESC;";
      grantsList = _dapper.LoadData<GrantDTO>(sql);
      lastUpdated = grantsList.First().Updated;
    }
    catch (Exception)
    {
      ErrorMessage = "Таблица пустая!";
    }
  }
}
