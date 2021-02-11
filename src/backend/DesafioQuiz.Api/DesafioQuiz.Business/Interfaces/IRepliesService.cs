using DesafioQuiz.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Business.Interfaces
{
    public interface IRepliesService : IDisposable
    {
        IEnumerable<Replies> GetAll();
    }
}
