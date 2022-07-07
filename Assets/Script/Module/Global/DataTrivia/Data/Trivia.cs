namespace Module.DataTrivia
{
    [System.Serializable]
    public class Trivia
    {
        public string number;
        public string question;
        public string[] answer;
        public string correctAnswer;
    }

    [System.Serializable]
    public class SoalTriviaCollection
    {
        public Trivia[] Trivia;
    }
}