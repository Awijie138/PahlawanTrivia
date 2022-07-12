using Agate.MVC.Base;
using UnityEngine;

using System.Collections;

namespace Trivia.Module.DataTrivia
{
    public class DataTriviaController : DataController<DataTriviaController, DataTriviaModel, IDataTriviaModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            SetTriviaData();
        }

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();

        }

        public void SetTriviaData()
        {
            Debug.Log(_model);
            _model.SetSoalTrivia();
        }
    }
}