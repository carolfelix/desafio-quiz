using DesafioQuiz.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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
