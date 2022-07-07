using Agate.MVC.Base;

using Module.LevelStatus;
using Module.DataTrivia;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utility;

namespace Module.Gameplay
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
            SetLevel(_levelStatus.Model.level);
            SetTrivia(_model.levelNumber);
        }

        public void SetLevel(int level)
        {
            _model.SetLevel(level);
        }

        public void SetTrivia(int level)
        {
            _model.SetTrivia(_dataTrivia.Model.soalTriviaCollection.Trivia[level].number,
            _dataTrivia.Model.soalTriviaCollection.Trivia[level].question,
            _dataTrivia.Model.soalTriviaCollection.Trivia[level].correctAnswer,
            _dataTrivia.Model.soalTriviaCollection.Trivia[level].answer);
        }

        public void Choose1()
        {
            AnswerCheck(_model.answer1, _model.rightAnswer);
        }
        public void Choose2()
        {
            AnswerCheck(_model.answer2, _model.rightAnswer);
        }
        public void Choose3()
        {
            AnswerCheck(_model.answer3, _model.rightAnswer);
        }

        public void AnswerCheck(string answer, string correctAnswer)
        {
            if (answer == correctAnswer)
            {
                Debug.Log("Benar");
                _message.IsAnswerCorrect = true;
                Publish<AnswersMessage>(_message);
                _model.NextLevel();
                _levelStatus.Unlock(_model.levelNumber);
                SetTrivia(_model.levelNumber);
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


