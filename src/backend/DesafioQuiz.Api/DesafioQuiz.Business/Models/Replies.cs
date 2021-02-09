using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioQuiz.Business.Models
{
    public class Replies : Entity
    {
        public string Description { get; set; }
        public int QuestionId { get; set; }
        public bool AnswerCorrect { get; set; }

    }
}
