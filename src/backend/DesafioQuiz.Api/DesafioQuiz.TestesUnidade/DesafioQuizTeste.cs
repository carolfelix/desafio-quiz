using DesafioQuiz.Data.Context;
using DesafioQuiz.Data.Interfaces;
using DesafioQuiz.Data.Repository;
using DesafioQuiz.Model;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesafioQuiz.TestesUnidade
{
    public class Tests
    {
        private QuestionRepository questionRepository;
        private DesafioQuizContext context;
        private DbContextOptions DbContextOptions;


        [SetUp]
        public void Setup()
        {
            context = new DesafioQuizContext(DbContextOptions);
            questionRepository = new QuestionRepository(context);
        }

        [Test]
        public void TestGetAllQuestions()
        {
            var questoesEsperada = new List<Question>()
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

            var questoesEncontrada = questionRepository.GetAll();

            CollectionAssert.AreEqual(questoesEsperada, questoesEncontrada);
        }
    }
}