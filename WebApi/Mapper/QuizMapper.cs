using BackendLab01;
using WebApi.DTO;

namespace WebApi.Mapper;

public class QuizMapper
{
    public static QuizDTO QuizToDTO(Quiz quiz)
    {
        return new QuizDTO()
        {
            Id = quiz.Id,
            Title = quiz.Title,
            Items = quiz.Items.Select(i => ItemToDTO(i)).ToList()
        };
    }

    public static QuizItemDTO ItemToDTO(QuizItem quizItem) 
    {
        quizItem.IncorrectAnswers.Add(quizItem.CorrectAnswer);
        return new QuizItemDTO()
        {
            Id = quizItem.Id,
            Title = quizItem.Question,
            Options = quizItem.IncorrectAnswers
        };
    }
}
