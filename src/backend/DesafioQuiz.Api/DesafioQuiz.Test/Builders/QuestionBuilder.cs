using AutoBogus;
using DesafioQuiz.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Test.Builders
{
    public class QuestionBuilder : AutoFaker<Question>
    {
        public QuestionBuilder()
        {
            RuleFor(question => question.Id, () => 0)
                .RuleFor(question => question.Description, faker => faker.Name.FullName())
                .RuleFor(question => question.Guid, faker => faker.Random.Guid());
        }
    }
}
