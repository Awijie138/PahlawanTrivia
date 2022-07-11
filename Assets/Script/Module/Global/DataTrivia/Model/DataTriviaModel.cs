using Agate.MVC.Base;
using UnityEngine;

namespace Trivia.Module.DataTrivia
{
    public class DataTriviaModel : BaseModel, IDataTriviaModel
    {
        public SoalTriviaCollection SoalTriviaCollection { get; private set; }
        public void SetSoalTrivia()
        {
            TextAsset DataTrivia = Resources.Load(@"Trivia") as TextAsset;
            SoalTriviaCollection _source = JsonUtility.FromJson<SoalTriviaCollection>(DataTrivia.text);
            SoalTriviaCollection = _source;
        }
    }
}


