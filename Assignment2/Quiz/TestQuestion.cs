namespace Assignment2.Quiz
{
    public class TestQuestion : AbstractQuestion
    {
        private List<string> options;
        private int correctId;

        public TestQuestion(QuestionType category, string question, int points) : base(category, question, points)
        {
            options = new List<string>();
            correctId = -1;
        }

        public override bool EvaluateAnswer(string guess)
        {
            foreach (string option in options)
            {
                if (string.Equals(guess, option, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddOption(string option)
        {
            if (!options.Contains(option, StringComparer.OrdinalIgnoreCase))
            {
                options.Add(option);
            }
        }

        public void SetCorrect(int id)
        {
            if(id>=0 && id < options.Count){
                correctId = id;
            }
        }

        public override string getAnswer()
        {
            return options[correctId];
        }

        public int GetOptionsCount()
        {
            return options.Count;
        }
    }
}
