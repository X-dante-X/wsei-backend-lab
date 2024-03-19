namespace WebApi.DTO;

public class QuizItemUserAnswerDTO
{
    public int QuizId { get; set; }

    public int QuizItemId { get; set; }
    public int UserId { get; set; }
    public string Answer {get; set; }

}

