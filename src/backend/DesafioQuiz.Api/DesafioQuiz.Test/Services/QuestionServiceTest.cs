using DesafioQuiz.Business.Services;
using DesafioQuiz.Data.Interfaces;
using DesafioQuiz.Model;
using DesafioQuiz.Test.Builders;
using DesafioQuiz.Test.Unit.Builders;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesafioQuiz.Test.Services
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
        public void ShouldReturnsAllQuestions()
        {
            var listQuestions = new List<Question>();

            var questions = new QuestionBuilder().Generate(4);

            listQuestions.ForEach(question => listQuestions.Add(question));
          
            mockQuestionRepository.Setup(x => x.GetAll()).Returns(listQuestions);

            var result = questionService.GetAll();

            mockQuestionRepository.Verify(x => x.GetAll(), Times.Once);

            result.Should().BeEquivalentTo(listQuestions);
        }

        [TestCase(15)]
        [TestCase(1)]
        [TestCase(11)]
        [TestCase(28)]
        public void ShouldReturnsAResultWithTotalAmountOfQuestionsInRepository(int amountOfQuestions)
        {
            var questions = new QuestionBuilder().Generate(amountOfQuestions);

            mockQuestionRepository.Setup(x => x.GetAll()).Returns(questions);

            var result = questionService.GetAll();

            var totalQuestions = result.Count();

            totalQuestions.Should().Be(amountOfQuestions);
        }

        [Test]
        public void ShouldReturnsListOfNullQuestions()
        {
            var listQuestions = new List<Question>() { null };

            mockQuestionRepository.Setup(x => x.GetAll()).Returns(listQuestions);

            var result = questionService.GetAll();

            result.Should().BeEquivalentTo(listQuestions);
        }

    }
}
