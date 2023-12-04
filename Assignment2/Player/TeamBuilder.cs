using Assignment2.Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Player
{
    public static class TeamBuilder
    {
        public static List<QuizPlayer>? FindBestTeam(QuestionQuiz quiz, List<QuizPlayer> allPlayers, int count)
        {
            if (count <= 0 || count > allPlayers.Count || quiz == null)
            {
                return null;
            }

            var bestTeam = new List<QuizPlayer>();
            var categories = GetSortedScoredCategories(quiz);
            var scoredPlayers = allPlayers.Select(player => new PlayerScore(player, 0)).ToList();
            var categoriesCount = categories.Count;

            for (int i = 0; i < categoriesCount; i++)
            {
                foreach (var player in scoredPlayers)
                {
                    foreach (var category in categories)
                    {
                        player.Score += player.Player.GetKnowledgeLevel(category.Key) * category.Value;
                    }
                }

                var bestPlayer = scoredPlayers.OrderByDescending(p => p.Score).First();
                bestTeam.Add(bestPlayer.Player);
                if (bestTeam.Count == count)
                {
                    break;
                }

                scoredPlayers.Remove(bestPlayer);
                categories.Remove(0);
            }

            while (bestTeam.Count < count)
            {
                var bestPlayer = scoredPlayers.OrderByDescending(p => p.Score).First();
                bestTeam.Add(bestPlayer.Player);
                scoredPlayers.Remove(bestPlayer);
            }

            return bestTeam;
        }

        private static Dictionary<QuestionType, int> GetSortedScoredCategories(QuestionQuiz quiz)
        {
            var categories = new Dictionary<QuestionType, int>();
            foreach (var question in quiz)
            {
                var category = question.Category;
                var points = question.Points;
                if (!categories.ContainsKey(category))
                {
                    categories.Add(category, 0);
                }
                categories[category] += points;
            }
            categories = categories.OrderByDescending(category => category.Value).ToDictionary(k => k.Key, v => v.Value);
            return categories;
        }

        public static List<List<QuizPlayer>>? FindDuos(QuestionQuiz quiz, List<QuizPlayer> allPlayers, int count)
        {
            if (count <= 0 || count > allPlayers.Count)
            {
                return null;
            }

            var duos = new List<List<QuizPlayer>>();

            while (allPlayers.Count > 1)
            {
                var bestTeam = FindBestTeam(quiz, allPlayers, 2);
                if (bestTeam == null)
                {
                    break;
                }
                duos.Add(bestTeam);
                allPlayers.Remove(bestTeam[0]);
                allPlayers.Remove(bestTeam[1]);
            }

            return duos;
        }
    }
}
