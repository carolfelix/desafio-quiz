using DesafioQuiz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioQuiz.Api.ViewModels
{
    public class QuestionViewModel 
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public List<Replies> ListReplies { get; set; }
    }
}

