using DesafioQuiz.Model;
using Microsoft.EntityFrameworkCore;

namespace DesafioQuiz.Data.Context
{
    public class DesafioQuizContext : DbContext
    {
        public DesafioQuizContext(DbContextOptions options)
            :base(options)
        {}

        public DbSet<Question> Questions { get; set; }
        public DbSet<Replies> Replies { get; set; }

    }
}
