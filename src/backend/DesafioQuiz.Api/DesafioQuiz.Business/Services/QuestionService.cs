using DesafioQuiz.Business.Interfaces;
using DesafioQuiz.Data.Interfaces;
using DesafioQuiz.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Business.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;
        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public void Dispose()
        {
            _questionRepository?.Dispose();
        }

        public IEnumerable<Question> GetAll()
        {
            return _questionRepository.GetAll();
        }
    }
}
