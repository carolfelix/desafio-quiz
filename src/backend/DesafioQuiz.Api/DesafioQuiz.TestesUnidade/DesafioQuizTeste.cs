using DesafioQuiz.Business.Interfaces;
using DesafioQuiz.Business.Services;
using DesafioQuiz.Data.Context;
using DesafioQuiz.Data.Interfaces;
using DesafioQuiz.Data.Repository;
using DesafioQuiz.Model;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesafioQuiz.TestesUnidade
{
    public class Tests
    {
        private  Mock<QuestionService> mockQuestionService;
        private  Mock<IQuestionRepository> mockQuestionRepository;
        private  QuestionService questionService;


        [SetUp]
        public void Setup()
        {
            mockQuestionService = new Mock<QuestionService>();
            mockQuestionRepository = new Mock<IQuestionRepository>();
            questionService = new QuestionService(mockQuestionRepository.Object);

        }

        [Test]
        public void GetAllQuestions()
        {
            var list = new List<Question>()
            {
                new Question()
                {
                    Id = 3,
                    Description = "Em que país fica Paris?"
                },
                new Question()
                {
                    Id = 4,
                    Description = "Quantos anos tem 1 década?"
                },
                new Question()
                {
                    Id = 6,
                    Description = "Quanto é 20 + 2?"
                },
                new Question()
                {
                    Id = 8,
                    Description = "Do que a Carol mais gosta?"
                }
            };

            mockQuestionRepository.Setup(x => x.GetAll()).Returns(list);

            questionService.GetAll();

            mockQuestionRepository.Verify(x => x.GetAll(), Times.Once);
        }
    }
}