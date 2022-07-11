using Agate.MVC.Base;
using Trivia.Module.Gameplay;
using Trivia.Module.LevelStatus;
using Trivia.Utility;

using UnityEngine;
using UnityEngine.SceneManagement;


namespace Trivia.Module.Level
{
    public class LevelController : ObjectController<LevelController, LevelModel, ILevelModel, LevelView>
    {

        private LevelStatusController _levelStatus;

        public override void SetView(LevelView view)
        {
            base.SetView(view);
            view.Init(LevelSelect, Onback);
        }

        public void SetLevel(int source)
        {
            _model.SetLevel(source);
            _levelStatus.SetLevel(_model.Level);
        }

        public void LevelSelect(int number)
        {
            SetLevel(number);
            bool IsUnlockResult = _levelStatus.IsUnlock(_model.Level);

            if (IsUnlockResult)
            {
                Debug.Log("Level " + _model.LevelNumber + " is unlock");
                SceneManager.LoadScene(Scenes.GamePlay, LoadSceneMode.Additive);
            }
            else
            {
                Debug.Log("Level " + _model.LevelNumber + " is lock");
                Publish<LockMessage>(new LockMessage());
            }

        }

        public void Onback()
        {
            SceneManager.LoadScene(Scenes.MainMenu, LoadSceneMode.Additive);
        }
    }
}
