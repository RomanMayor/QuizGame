using System;

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
            var correctAnswer = options[correctId];
            return string.Equals(guess, correctAnswer, StringComparison.OrdinalIgnoreCase);
        }

        public virtual void AddOption(string option)
        {
            if (!options.Contains(option, StringComparer.OrdinalIgnoreCase))
            {
                options.Add(option);
            }
        }

        public virtual void SetCorrect(int id)
        {
            if(id >= 0 && id < options.Count){
                correctId = id;
            }
        }

        public override string GetAnswer(float probability)
        {
            if (probability > 0)
            {
                return Random.NextDouble() < probability ? options[correctId] : WRONG_ANSWER;
            }
            return Random.NextDouble() < 1.0 / options.Count ? options[correctId] : WRONG_ANSWER;
        }

        public int GetOptionsCount()
        {
            return options.Count;
        }
    }
}
