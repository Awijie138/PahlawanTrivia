using Agate.MVC.Base;
using Module.Gameplay;
using Module.Level;
using UnityEngine;

namespace Module.SoundEffect
{
    public class SoundEffectController : BaseController<SoundEffectController>
    {
        // Start is called before the first frame update
        public void AnswerSound(AnswersMessage message)
        {
            if (message.IsAnswerCorrect == true)
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

