using DesafioQuiz.Data.Context;
using DesafioQuiz.Data.Interfaces;
using DesafioQuiz.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Data.Repository
{
    public class RepliesRepository : BaseRepository<Replies>, IRepliesRepository
    {
        public RepliesRepository(DesafioQuizContext context) : base(context)
        {}
    }
}
