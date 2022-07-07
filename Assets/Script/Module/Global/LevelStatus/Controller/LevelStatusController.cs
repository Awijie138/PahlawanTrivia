using Agate.MVC.Base;
using UnityEngine;

namespace Module.LevelStatus
{
    public class LevelStatusController : DataController<LevelStatusController, LevelStatusModel, ILevelStatusModel>
    {
        public bool IsUnlock(int level)
        {
            return _model.CheckStatus(level);
        }
        public void Unlock(int level)
        {
            _model.UnlockLevel(level);
        }
        public void Reset()
        {
            _model.Reset();
        }

        public void SetLevel(int level)
        {
            _model.SetLevel(level);
        }
    }

}

