namespace DesafioQuiz.Model
{
    public class Replies : Entity
    {
        public string Description { get; set; }
        public int QuestionId { get; set; }
        public bool AnswerCorrect { get; set; }

    }
}
