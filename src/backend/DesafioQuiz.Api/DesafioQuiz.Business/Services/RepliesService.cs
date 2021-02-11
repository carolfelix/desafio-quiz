using DesafioQuiz.Business.Interfaces;
using DesafioQuiz.Data.Interfaces;
using DesafioQuiz.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Business.Services
{
    public class RepliesService : IRepliesService
    {
        private readonly IRepliesRepository _repliesRepository;
        public RepliesService(IRepliesRepository repliesRepository)
        {
            _repliesRepository = repliesRepository;
        }

        public void Dispose()
        {
            _repliesRepository?.Dispose();
        }

        public IEnumerable<Replies> GetAll()
        {
            return _repliesRepository.GetAll();
        }
    }
}
