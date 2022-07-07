using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace Module.Gameplay
{
    public interface IGameplayModel : IBaseModel
    {
        int levelNumber { get; }
        string questionNumber { get; }
        string question { get; }
        string rightAnswer { get; }
        string answer1 { get; }
        string answer2 { get; }
        string answer3 { get; }
        static List<string> answers { get; }

    }

    public class GameplayModel : BaseModel, IGameplayModel
    {
        public int levelNumber { get; protected set; }

        public string questionNumber { get; protected set; }
        public string question { get; protected set; }

        public string rightAnswer { get; protected set; }

        public static List<string> answers { get; protected set; }

        public string answer1 { get; protected set; }
        public string answer2 { get; protected set; }
        public string answer3 { get; protected set; }


        //Debug, ganti ke non static later
        public static string RandomAnswer()
        {
            int number = Random.Range(0, answers.Count);

            string result = answers[number];

            answers.RemoveAt(number);

            return result;
        }

        public void SetTrivia(string questionNumberSource, string questionSource, string rightAnswerSource, string[] answersSource)
        {
            questionNumber = questionNumberSource;
            question = questionSource;
            rightAnswer = rightAnswerSource;
            answers = new List<string>(answersSource);
            answer1 = RandomAnswer();
            answer2 = RandomAnswer();
            answer3 = RandomAnswer();
            SetDataAsDirty();

        }

        public void SetLevel(int source)
        {
            levelNumber = source;
            SetDataAsDirty();
        }

        public void NextLevel()
        {
            if (levelNumber == 9)
            {
                levelNumber = 0;
            }
            else
            {
                levelNumber++;
            }
            SetDataAsDirty();
        }

        public void Reset()
        {
            levelNumber = 0;
            question = null;
            rightAnswer = null;
            answers = null;
            SetDataAsDirty();
        }
    }
}



