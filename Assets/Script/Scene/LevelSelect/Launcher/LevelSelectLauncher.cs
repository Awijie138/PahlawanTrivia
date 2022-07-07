using Agate.MVC.Base;
using Agate.MVC.Core;
using Module.Level;
using Boot;
using Utility;
using System.Collections;
using UnityEngine;

namespace Scene.LevelSelect
{
    public class LevelSelectLauncher : SceneLauncher<LevelSelectLauncher, LevelSelectView>
    {
        private LevelController _level;
        public override string SceneName => Scenes.LevelSelect;

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

