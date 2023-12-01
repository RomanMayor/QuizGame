using Assignment2.Player;
using Assignment2.Quiz;

namespace Assignment2
{
    internal class Program
    {
        static List<QuizPlayer>? FindBestTeam(QuestionQuiz quiz, List<QuizPlayer> allPlayers, int count)
        {


            if (count <= 0 || count > allPlayers.Count)
            {
                return null;
            }

            List<QuizPlayer> bestTeam = new List<QuizPlayer>();

            for(int i =0; i<count; i++){
                QuestionType type = quiz.GetNextQuestion().Category;

                foreach(QuizPlayer player in allPlayers){
                    Dictionary<QuestionType, float> levels = player.GetKnowledgeLevel();
                    
                    
                }
            }
            
            return bestTeam;
        }


        static List<List<QuizPlayer>>? FindDuos(QuestionQuiz quiz, List<QuizPlayer> allPlayers, int count)
        {
            if (count <= 0 || count > allPlayers.Count)
            {
                return null;
            }

            return null;
        }

        static void Main(string[] args)
        {
            
        }
    }
}