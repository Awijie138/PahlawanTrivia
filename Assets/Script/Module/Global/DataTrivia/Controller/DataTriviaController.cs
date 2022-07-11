using Agate.MVC.Base;

namespace Trivia.Module.DataTrivia
{
    public class DataTriviaController : DataController<DataTriviaController, DataTriviaModel, IDataTriviaModel>
    {
        public void SetTriviaData()
        {
            _model.SetSoalTrivia();
        }
    }
}