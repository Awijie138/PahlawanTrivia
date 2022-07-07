using Agate.MVC.Base;

using System.Collections.Generic;


namespace Module.LevelStatus
{
    public interface ILevelStatusModel : IBaseModel
    {
        int level { get; }
        List<string> status { get; }
    }
    public class LevelStatusModel : BaseModel, ILevelStatusModel
    {
        public int level { get; protected set; }
        public List<string> status { get; protected set; } = new List<string> { "Unlock", "Lock", "Lock", "Lock", "Lock", "Lock", "Lock", "Lock", "Lock", "Lock", };

        public void UnlockLevel(int level)
        {
            status[level] = "Unlock";
        }

        public void SetLevel(int source)
        {
            level = source;
        }

        public void Reset()
        {
            for (int i = 0; i < status.Count; i++)
            {
                if (i == 1)
                {
                    status[i] = "Unlock";
                }
                status[i] = "Lock";
            }
        }

        public bool CheckStatus(int level)
        {
            if (status[level] == "Unlock")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}