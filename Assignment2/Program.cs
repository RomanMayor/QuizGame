using Assignment2.Player;
using Assignment2.Quiz;
using System.Collections.Generic;

namespace Assignment2
{
    internal class Program
    {
        static List<QuizPlayer>? FindBestTeam(QuestionQuiz quiz, List<QuizPlayer> allPlayers, int count)
        {
            return TeamBuilder.FindBestTeam(quiz, allPlayers, count);
        }     

        static List<List<QuizPlayer>>? FindDuos(QuestionQuiz quiz, List<QuizPlayer> allPlayers, int count)
        {
            return TeamBuilder.FindDuos(quiz, allPlayers, count);
        }

        static void Main(string[] args)
        {
            
        }
    }
}