using Agate.MVC.Base;
using Trivia.Module.Gameplay;
using Trivia.Module.Level;
using UnityEngine;

namespace Trivia.Module.SoundEffect
{
    public class SoundEffectController : BaseController<SoundEffectController>
    {
        public void AnswerSound(AnswersMessage message)
        {
            bool IsCorrect = message.IsAnswerCorrect;
            if (IsCorrect)
            {
                Debug.Log("Correct sound play");
            }
            else
            {
                Debug.Log("Wrong sound play");
            }
        }

        public void LockSound(LockMessage message)
        {
            Debug.Log("Level lock sound play");
        }

    }

}

