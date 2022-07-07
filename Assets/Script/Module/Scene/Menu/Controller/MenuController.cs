using Agate.MVC.Base;
using Utility;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Module.Menu
{
    public class MenuController : ObjectController<MenuController, MenuView>
    {
        public override void SetView(MenuView view)
        {
            base.SetView(view);
            view.Init(OnPlay, OnExit);
        }

        public void OnPlay()
        {
            SceneManager.LoadScene(Scenes.LevelSelect, LoadSceneMode.Additive);
        }

        public void OnExit()
        {
            Application.Quit();
        }
    }
}


