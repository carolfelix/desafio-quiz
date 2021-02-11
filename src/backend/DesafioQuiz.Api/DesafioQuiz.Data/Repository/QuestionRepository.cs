using DesafioQuiz.Data.Context;
using DesafioQuiz.Data.Interfaces;
using DesafioQuiz.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Data.Repository
{
    public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(DesafioQuizContext context) : base(context)
        { }

    }
}
