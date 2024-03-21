using BackendLab01;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTO;
using WebApi.Mapper;

namespace WebApi.Controllers;

[ApiController]
[Route("/api/v1/user/quizzes")]
public class WebApiUserQuiz :ControllerBase
{
    private readonly IQuizUserService _quizUserService;

    public WebApiUserQuiz(IQuizUserService quizUserService)
    {
        _quizUserService = quizUserService;

    }

    [Route("{id}")]
    [HttpGet]
    public ActionResult<QuizDTO?> GetOneQuiz(int id)
    {
        var quiz = _quizUserService.FindQuizById(id);
        if (quiz == null) 
        {
            return NotFound();
        }
        return QuizMapper.QuizToDTO(quiz);
    }

    [HttpPost]
    [Route("{quizId}/items/{itemId}/answers")]
    public ActionResult SaveUserAnswer(QuizItemUserAnswerDTO dto, int quizId, int itemId)
    {
        try 
        {
            _quizUserService.SaveUserAnswerForQuiz(quizId, dto.UserId, itemId, dto.Answer);
            return Created("uri to answer",null);
        }
        catch (Exception ex) 
        {
            return Problem(ex.Message);
        }
    }

}
