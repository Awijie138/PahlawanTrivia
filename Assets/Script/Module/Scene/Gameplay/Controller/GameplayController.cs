using Agate.MVC.Base;
using Trivia.Module.DataTrivia;
using Trivia.Module.LevelStatus;
using Trivia.Utility;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Trivia.Module.Gameplay
{
    public class GameplayController : ObjectController<GameplayController, GameplayModel, IGameplayModel, GameplayView>
    {
        private DataTriviaController _dataTrivia;
        private LevelStatusController _levelStatus;
        private AnswersMessage _message = new AnswersMessage();

        public override void SetView(GameplayView view)
        {
            base.SetView(view);
            view.Init(Back, Choose1, Choose2, Choose3);

            int LevelSelect = _levelStatus.Model.Level;
            SetLevel(LevelSelect);
            SetTrivia(_model.Level);
        }

        public void SetLevel(int level)
        {
            _model.SetLevel(level);
        }

        public void SetTrivia(int level)
        {
            string number = _dataTrivia.Model.SoalTriviaCollection.Trivia[level].Number;
            string question = _dataTrivia.Model.SoalTriviaCollection.Trivia[level].Question;
            string correctAnswer = _dataTrivia.Model.SoalTriviaCollection.Trivia[level].CorrectAnswer;
            string[] answers = _dataTrivia.Model.SoalTriviaCollection.Trivia[level].Answer;

            _model.SetTrivia(number, question, correctAnswer, answers);
        }

        public void Choose1()
        {
            string playerAnswer = _model.AnswerA;
            string rightAnswer = _model.RightAnswer;
            AnswerCheck(playerAnswer, rightAnswer);
        }

        public void Choose2()
        {
            string playerAnswer = _model.AnswerB;
            string rightAnswer = _model.RightAnswer;
            AnswerCheck(playerAnswer, rightAnswer);
        }

        public void Choose3()
        {
            string playerAnswer = _model.AnswerC;
            string rightAnswer = _model.RightAnswer;
            AnswerCheck(playerAnswer, rightAnswer);
        }

        public void AnswerCheck(string playerAnswer, string correctAnswer)
        {
            if (playerAnswer == correctAnswer)
            {
                Debug.Log("Benar");
                _message.IsAnswerCorrect = true;
                Publish<AnswersMessage>(_message);
                _model.NextLevel();
                _levelStatus.Unlock(_model.Level);
                SetTrivia(_model.Level);
            }
            else
            {
                Debug.Log("Salah");
                _message.IsAnswerCorrect = false;
                Publish<AnswersMessage>(_message);
            }
        }

        public void Back()
        {
            SceneManager.LoadScene(Scenes.LevelSelect, LoadSceneMode.Additive);
        }
    }
}


