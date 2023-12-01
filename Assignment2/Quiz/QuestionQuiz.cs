// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Quiz
{
    public class QuestionQuiz : IEnumerable<AbstractQuestion>
    {
        private List<AbstractQuestion> questions;
        private int length;
        private int current;

        public QuestionQuiz(int length)
        {
            this.questions = new List<AbstractQuestion>();
            this.length = length;
            this.current = 0;
        }

        public void AddQuestion(AbstractQuestion question)
        {
            if(questions.Count<length && !questions.Contains(question))
            {
                questions.Add(question);
            }
        }

        public void Reset()
        {
            current = 0;
        }

        public AbstractQuestion? GetNextQuestion()
        {
            if (questions.Count < length)
            {
                return null;
            }
            else if(current == length)
            {
                return null;
            }
            AbstractQuestion nextQuestion = questions[current++];
            return nextQuestion;
        }

        // Implementation of IEnumerable<AbstractQuestion>
        public IEnumerator<AbstractQuestion> GetEnumerator()
        {
            return questions.GetEnumerator();
        }

        // Explicit implementation for the non-generic IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}


