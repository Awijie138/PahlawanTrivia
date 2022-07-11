using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using Trivia.Boot;
using Trivia.Module.DataTrivia;
using Trivia.Module.Gameplay;
using Trivia.Utility;

namespace Trivia.Scene.Game
{
    public class GameLauncher : SceneLauncher<GameLauncher, GameView>
    {
        public override string SceneName => Scenes.GamePlay;
        private GameplayController _gameplay;
        private DataTriviaController _dataTrivia;
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

