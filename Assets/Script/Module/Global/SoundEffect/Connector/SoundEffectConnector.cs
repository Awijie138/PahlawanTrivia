using Agate.MVC.Base;
using Trivia.Module.Gameplay;
using Trivia.Module.Level;

namespace Trivia.Module.SoundEffect
{
    public class SoundEffectConnector : BaseConnector
    {
        private SoundEffectController _soundEffect;

        protected override void Connect()
        {
            Subscribe<AnswersMessage>(_soundEffect.AnswerSound);
            Subscribe<LockMessage>(_soundEffect.LockSound);
        }

        protected override void Disconnect()
        {
            Unsubscribe<AnswersMessage>(_soundEffect.AnswerSound);
            Unsubscribe<LockMessage>(_soundEffect.LockSound);
        }
    }
}


