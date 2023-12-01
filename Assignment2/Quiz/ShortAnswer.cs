namespace Assignment2.Quiz
{
    public class ShortAnswer : AbstractQuestion
    {
        private string answer;

        public ShortAnswer(QuestionType category, string question, int points, string answer) : base(category, question, points)
        {
            this.answer = answer;
        }

        public override bool EvaluateAnswer(string guess)
        {
            return string.Equals(guess, answer, StringComparison.OrdinalIgnoreCase);
        }

        public override string getAnswer()
        {
            return answer;
        }
    }
}
