using AutoMapper;
using DesafioQuiz.Api.ViewModels;
using DesafioQuiz.Business.Interfaces;
using DesafioQuiz.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DesafioQuiz.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : Controller
    {
        IMapper _mapper;
        IQuestionService _questionService;
        IRepliesService _repliesService;
        public QuizController(IMapper mapper, IQuestionService questionService, IRepliesService repliesService)
        {
            _mapper = mapper;
            _questionService = questionService;
            _repliesService = repliesService;
        }
        [HttpGet("get-questions")]
        public ActionResult GetAllQuestions()
        {
            var getQuestions = _questionService.GetAll();
            var question = new List<QuestionViewModel>();


            List<RepliesViewModel> getReplies = _mapper.Map<List<RepliesViewModel>>(_repliesService.GetAll());
            var replies = new List<RepliesViewModel>();


            foreach (var item in getQuestions)
            {

                foreach (var rep in getReplies.Where(x => x.QuestionId == item.Id))
                {
                    replies.Add(rep);
                }

                question.Add(new QuestionViewModel() { Id = item.Id, Description = item.Description, ListReplies = replies });

                replies = new List<RepliesViewModel>();


            }

            return Ok(question);
        }
    }
}
