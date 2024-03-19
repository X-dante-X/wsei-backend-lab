namespace WebApi.DTO;

public class QuizItemDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<string> Options { get; set; }
}
