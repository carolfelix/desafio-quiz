using DesafioQuiz.Business.Services;
using DesafioQuiz.Data.Interfaces;
using DesafioQuiz.Model;
using DesafioQuiz.Test.Unit.Builders;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Test.Unit.Services
{
    public class QuestionServiceTest
    {
        private Mock<QuestionService> mockQuestionService;
        private Mock<IQuestionRepository> mockQuestionRepository;
        private QuestionService questionService;


        [SetUp]
        public void Setup()
        {
            mockQuestionService = new Mock<QuestionService>();
            mockQuestionRepository = new Mock<IQuestionRepository>();
            questionService = new QuestionService(mockQuestionRepository.Object);

        }

        [Test]
        public void ShouldCallGetAllQuestions()
        {
            var list = new List<Question>();

            var questions = new QuestionBuilder().Generate(4);

            list.ForEach(question => list.Add(question));
          
            mockQuestionRepository.Setup(x => x.GetAll()).Returns(list);

           questionService.GetAll();

            mockQuestionRepository.Verify(x => x.GetAll(), Times.Once);
        }
    }
}
