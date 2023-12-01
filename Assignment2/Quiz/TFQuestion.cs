using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Quiz
{
    public class TFQuestion : TestQuestion
    {
        public TFQuestion(QuestionType category, string question, int points, bool isTrue) : base(category, question, points)
        {
            AddOption("true");
            AddOption("false");
            
            SetCorrect(isTrue ? 0 : 1);
        }

        public override bool EvaluateAnswer(string guess)
        {
            return base.EvaluateAnswer(guess);
        }
    }
}
