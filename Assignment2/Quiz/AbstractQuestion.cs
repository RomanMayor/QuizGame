using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Quiz
{
    public abstract class AbstractQuestion
    {
        protected string question;
        protected QuestionType category;
        protected int points;

        protected AbstractQuestion(QuestionType category, string question, int points)
        {
            //?
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

        public abstract string getAnswer();
        
        
    }
}
