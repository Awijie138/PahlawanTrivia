using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using Trivia.Boot;
using Trivia.Module.Level;
using Trivia.Utility;

namespace Trivia.Scene.LevelSelect
{
    public class LevelSelectLauncher : SceneLauncher<LevelSelectLauncher, LevelSelectView>
    {
        public override string SceneName => Scenes.LevelSelect;
        private LevelController _level;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {

            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
          {
              new LevelController()
          };
        }

        protected override IEnumerator InitSceneObject()
        {
            _level.SetView(_view.LevelView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}

