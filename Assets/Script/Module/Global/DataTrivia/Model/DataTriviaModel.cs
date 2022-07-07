using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

namespace Module.DataTrivia
{

    public interface IDataTriviaModel : IBaseModel
    {
        public SoalTriviaCollection soalTriviaCollection { get; }
    }

    public class DataTriviaModel : BaseModel, IDataTriviaModel
    {
        public SoalTriviaCollection soalTriviaCollection { get; private set; }

        public void SetSoalTrivia()
        {
            TextAsset dataTrivia = Resources.Load("Trivia") as TextAsset;
            SoalTriviaCollection _source = JsonUtility.FromJson<SoalTriviaCollection>(dataTrivia.text);
            soalTriviaCollection = _source;
        }
    }
}


