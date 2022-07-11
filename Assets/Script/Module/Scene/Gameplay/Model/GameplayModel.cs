using Agate.MVC.Base;
using System.Collections.Generic;
using UnityEngine;

namespace Trivia.Module.Gameplay
{
    public class GameplayModel : BaseModel, IGameplayModel
    {
        public int Level { get; protected set; }
        public string QuestionNumber { get; protected set; }
        public string Question { get; protected set; }
        public string RightAnswer { get; protected set; }
        public static List<string> AnswersList { get; protected set; }
        public string AnswerA { get; protected set; }
        public string AnswerB { get; protected set; }
        public string AnswerC { get; protected set; }

        public string RandomAnswer()
        {
            int number = Random.Range(0, AnswersList.Count);
            string result = AnswersList[number];
            AnswersList.RemoveAt(number);
            return result;
        }

        public void SetTrivia(string questionNumberSource, string questionSource, string rightAnswerSource, string[] answersSource)
        {
            QuestionNumber = questionNumberSource;
            Question = questionSource;
            RightAnswer = rightAnswerSource;
            AnswersList = new List<string>(answersSource);
            AnswerA = RandomAnswer();
            AnswerB = RandomAnswer();
            AnswerC = RandomAnswer();
            SetDataAsDirty();
        }

        public void SetLevel(int source)
        {
            Level = source;
            SetDataAsDirty();
        }

        public void NextLevel()
        {
            if (Level == 9)
            {
                Level = 0;
            }
            else
            {
                Level++;
            }
            SetDataAsDirty();
        }

        public void Reset()
        {
            Level = 0;
            Question = null;
            RightAnswer = null;
            AnswersList = null;
            SetDataAsDirty();
        }
    }
}



