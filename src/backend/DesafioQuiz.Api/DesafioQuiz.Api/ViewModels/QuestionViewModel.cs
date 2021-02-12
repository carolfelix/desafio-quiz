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
        public string Description { get; set; }
        public List<RepliesViewModel> ListReplies { get; set; }
    }
}

