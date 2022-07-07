using Agate.MVC.Base;

namespace Module.Level
{
    public interface ILevelModel : IBaseModel
    {
        int levelNumber { get; }
        int level { get; }
    }
    public class LevelModel : BaseModel, ILevelModel
    {
        public int levelNumber { get; set; }
        public int level { get; set; }

        public void SetLevel(int source)
        {
            levelNumber = source;
            level = levelNumber - 1;
        }

        public int GetLevel()
        {
            return level;
        }
    }
}

