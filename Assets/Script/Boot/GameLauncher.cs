using Agate.MVC.Base;
using Agate.MVC.Core;
using Module.DataTrivia;
using Module.LevelStatus;
using Module.SoundEffect;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Boot
{
    public class GameLauncher : BaseMain<GameLauncher>, IMain
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
            CreateEventSystem();
            yield return null;
        }

        private void CreateEventSystem()
        {
            GameObject obj = new GameObject("Event System");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>();
            GameObject.DontDestroyOnLoad(obj);
        }
    }
}