using Agate.MVC.Base;
using Module.Gameplay;
using Module.Level;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Module.SoundEffect
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


