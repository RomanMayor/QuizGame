using Assignment2.Quiz;

namespace Assignment2.Player
{
    public class KnowItAll : QuizPlayer
    {
        public KnowItAll(List<QuestionType> interests) : base(new Dictionary<QuestionType, float>())
        {
            foreach(QuestionType interest in interests){
                SetKnowledgeLevel(interest, 1f);
            }
        }

        public override string GetGuess(AbstractQuestion question)
        {
            string end = "f";
            if (knowledgeLevel.ContainsKey(question.Category))
            {       
                end = question.getAnswer();
            }
            else
            {
                if(question is ShortAnswer || question is TFQuestion)
                {

                    Random random = new Random();
                    bool randomGuess = random.NextDouble() < 0.5; 


                    end = randomGuess ? question.getAnswer() : "f";
                }
                else if(question is TestQuestion)
                {
                    TestQuestion testQuestion = (TestQuestion)question;
                    Random random = new Random();
                    bool randomGuess = random.NextDouble() < 1.0/testQuestion.GetOptionsCount(); 


                    end = randomGuess ? question.getAnswer() : "f";
                } 
            }
            return end;
        }
    }
}
