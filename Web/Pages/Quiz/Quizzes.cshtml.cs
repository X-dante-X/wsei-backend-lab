using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackendLab01;

public class Quizzes : PageModel
{
    private readonly IQuizAdminService _adminService;

    public Quizzes(IQuizAdminService adminService)
    {
        _adminService = adminService;
    }
    [BindProperty]
    public List<Quiz> Answers { get; set; }
    public void OnGet()
    {
        Answers = _adminService.FindAllQuizzes();
    }
}
