using Agate.MVC.Base;
using Trivia.Boot;
using Trivia.Utility;
using UnityEngine;

namespace Trivia.Module.Menu
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
            SceneLoader.Instance.LoadScene(Scenes.LevelSelect);
        }

        public void OnExit()
        {
            Application.Quit();
        }
    }
}


