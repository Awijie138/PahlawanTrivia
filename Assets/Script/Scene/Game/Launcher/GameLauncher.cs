using Agate.MVC.Base;
using Agate.MVC.Core;
using Module.Gameplay;
using Module.DataTrivia;
using Boot;
using Utility;
using System.Collections;
using UnityEngine;

namespace Scene.Game
{
    public class GameLauncher : SceneLauncher<GameLauncher, GameView>
    {
        private GameplayController _gameplay;
        private DataTriviaController _dataTrivia;
        public override string SceneName => Scenes.GamePlay;
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
                new GameplayController(),
             };
        }

        protected override IEnumerator InitSceneObject()
        {
            _dataTrivia.SetTriviaData();
            _gameplay.SetView(_view.GameplayView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}

