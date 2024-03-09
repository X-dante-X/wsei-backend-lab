using ApplicationCore.Interfaces.Repository;
using BackendLab01;

namespace Infrastructure.Memory;
public static class SeedData
{
    public static void Seed(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var provider = scope.ServiceProvider;
            var quizRepo = provider.GetService<IGenericRepository<Quiz, int>>();
            var quizItemRepo = provider.GetService<IGenericRepository<QuizItem, int>>();

            var quiz1Item1 = new QuizItem(1, "guess", new List<string> { "A", "B", "C", "D", "F" },"K");
            var quiz1Item2 = new QuizItem(2, "guess", new List<string> { "Q", "W", "B", "G", "H" },"B");
            var quiz1Item3 = new QuizItem(3, "guess", new List<string> { "L", "B", "W", "Z", "X" },"C");
            var quiz1Item4 = new QuizItem(4, "guess", new List<string> { "W", "Q", "H", "D", "J" },"M");

            var quiz1Items = new List<QuizItem>() { quiz1Item1, quiz1Item2, quiz1Item3, quiz1Item4 };

            var quiz2Item1 = new QuizItem(1, "1 + 1", new List<string> { "1", "4", "3"},"2");
            var quiz2Item2 = new QuizItem(2, "10 - 5", new List<string> { "3", "5", "7"},"5");
            var quiz2Item3 = new QuizItem(3, "17 + 25", new List<string> { "45", "34", "39"},"42");
            var quiz2Item4 = new QuizItem(4, "7 * 7", new List<string> { "14", "41", "77" },"49");

            var quiz2Items = new List<QuizItem>() { quiz2Item1, quiz2Item2, quiz2Item3, quiz2Item4 };


            var quiz1 = new Quiz(1, quiz1Items, "guess");
            var quiz2 = new Quiz(2, quiz2Items, "math");

            quizItemRepo.Add(quiz1Item1);
            quizItemRepo.Add(quiz1Item2);
            quizItemRepo.Add(quiz1Item3);
            quizItemRepo.Add(quiz1Item4);
            quizItemRepo.Add(quiz2Item1);
            quizItemRepo.Add(quiz2Item2);
            quizItemRepo.Add(quiz2Item3);
            quizItemRepo.Add(quiz2Item4);

            quizRepo.Add(quiz1);
            quizRepo.Add(quiz2);
        }
    }
}