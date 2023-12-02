namespace Assignment2.Quiz
{
    public class TFQuestion : TestQuestion
    {
        public TFQuestion(QuestionType category, string question, int points, bool isTrue) : base(category, question, points)
        {
            base.AddOption("true");
            base.AddOption("false");
            
            base.SetCorrect(isTrue ? 0 : 1);
        }

        public override bool EvaluateAnswer(string guess)
        {
            return base.EvaluateAnswer(guess);
        }

        public override void SetCorrect(int id)
        {
            //do not change correct id
        }

        public override void AddOption(string option)
        {
            //we use only true/false options
        }
    }
}
