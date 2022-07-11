using Agate.MVC.Base;

namespace Trivia.Module.DataTrivia
{
    public interface IDataTriviaModel : IBaseModel
    {
        public SoalTriviaCollection SoalTriviaCollection { get; }
    }
}