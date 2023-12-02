namespace Assignment2.Quiz
{
    public abstract class AbstractQuestion
    {
        protected const string WRONG_ANSWER = "WRONG_ANSWER_98204985";

        protected readonly Random Random = new Random();
        protected string question;
        protected QuestionType category;
        protected int points;

        protected AbstractQuestion(QuestionType category, string question, int points)
        {
            this.question = question;
            this.category = category;
            this.points = points;
        }

        public QuestionType Category
        {
            get { return category; }
        }

        public int Points
        {
            get { return points; }
        }

        public abstract bool EvaluateAnswer(string guess);

        public abstract string GetAnswer(float probability);
    }
}
