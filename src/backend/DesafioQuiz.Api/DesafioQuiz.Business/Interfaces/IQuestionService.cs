using DesafioQuiz.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Business.Interfaces
{
    public interface IQuestionService : IDisposable
    {
        IEnumerable<Question> GetAll();
    }
}
