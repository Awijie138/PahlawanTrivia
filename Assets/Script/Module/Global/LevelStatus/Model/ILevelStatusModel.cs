using Agate.MVC.Base;
using System.Collections.Generic;

namespace Trivia.Module.LevelStatus
{
    public interface ILevelStatusModel : IBaseModel
    {
        int Level { get; }
        List<string> LevelStatusList { get; }
    }
}