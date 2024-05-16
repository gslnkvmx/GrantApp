using GrantApp.Data;
using GrantApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrantApp.Pages;

[Authorize]
public class IndexModel : PageModel
{
    DataContextDapper _dapper;
    public IEnumerable<StudentDTO> studentsList = [];
    public IndexModel(IConfiguration config)
    {
        _dapper = new DataContextDapper(config);
    }

    public void OnGet()
    {
        string sql = @"SELECT last_name, first_name, middle_name, phone_number, VK, study_groups.name AS group_name 
        FROM ac_database.students 
        JOIN ac_database.study_groups 
        ON students.study_group = study_groups.id;";

        studentsList = _dapper.LoadData<StudentDTO>(sql);
    }
}
