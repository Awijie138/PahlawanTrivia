using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using Trivia.Module.DataTrivia;
using Trivia.Module.LevelStatus;
using Trivia.Module.SoundEffect;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Trivia.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {
        protected override IConnector[] GetConnectors()
        {
            return new IConnector[]{
                new SoundEffectConnector()
            };
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]{
                new DataTriviaController(),
                new LevelStatusController(),
                new SoundEffectController()
            };
        }

        protected override IEnumerator StartInit()
        {
            yield return null;
        }
    }
}