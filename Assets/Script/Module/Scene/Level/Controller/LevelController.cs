using Agate.MVC.Base;
using Module.LevelStatus;
using Module.Gameplay;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utility;


namespace Module.Level
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
            _levelStatus.SetLevel(_model.level);
        }
        // Start is called before the first frame update
        public void LevelSelect(int number)
        {
            SetLevel(number);

            if (_levelStatus.IsUnlock(_model.level) == true)
            {
                Debug.Log("Level " + _model.levelNumber + " is unlock");
                SceneManager.LoadScene(Scenes.GamePlay, LoadSceneMode.Additive);
            }
            else
            {
                Debug.Log("Level " + _model.levelNumber + " is lock");
                Publish<LockMessage>(new LockMessage());
            }

        }

        // Update is called once per frame
        public void Onback()
        {
            SceneManager.LoadScene(Scenes.MainMenu, LoadSceneMode.Additive);
        }
    }
}
