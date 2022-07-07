using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;

namespace Boot
{
    public abstract class SceneLauncher<TLauncher, TView> : BaseLauncher<TLauncher, TView>
        where TLauncher : SceneLauncher<TLauncher, TView>
        where TView : BaseSceneView
    {

        protected override IMain GetMain()
        {
            return GameLauncher.Instance;
        }

        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }

    }
}


