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

        public override string  GetAnswer(float probability)
        {
            if(probability > 0)
            {
                return Random.NextDouble() < probability ? answer : WRONG_ANSWER;
            }
            return Random.NextDouble() < 0.5f ? answer : WRONG_ANSWER;
        }
    }
}
