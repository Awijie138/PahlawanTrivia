using UnityEngine;
using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;


namespace Module.DataTrivia
{
    public class DataTriviaController : DataController<DataTriviaController, DataTriviaModel, IDataTriviaModel>
    {
        public void SetTriviaData()
        {
            _model.SetSoalTrivia();
        }
    }
}