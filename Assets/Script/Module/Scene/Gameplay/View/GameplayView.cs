using Agate.MVC.Base;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using TMPro;


namespace Module.Gameplay
{
    public class GameplayView : ObjectView<IGameplayModel>
    {
        [SerializeField]
        private Button _exitButton, _answer1Button, _answer2Button, _answer3Button;
        [SerializeField]
        private TextMeshProUGUI _levelText, _questionText;

        public void Init(UnityAction back, UnityAction chooseA, UnityAction chooseB, UnityAction chooseC)
        {
            _exitButton.onClick.RemoveAllListeners();
            _exitButton.onClick.AddListener(back);
            _answer1Button.onClick.RemoveAllListeners();
            _answer1Button.onClick.AddListener(chooseA);
            _answer2Button.onClick.RemoveAllListeners();
            _answer2Button.onClick.AddListener(chooseB);
            _answer3Button.onClick.RemoveAllListeners();
            _answer3Button.onClick.AddListener(chooseC);
        }
        protected override void InitRenderModel(IGameplayModel model)
        {
            _levelText.text = model.questionNumber;
            _questionText.text = model.question;
            _answer1Button.GetComponentInChildren<TextMeshProUGUI>().text = model.answer1;
            _answer2Button.GetComponentInChildren<TextMeshProUGUI>().text = model.answer2;
            _answer3Button.GetComponentInChildren<TextMeshProUGUI>().text = model.answer3;
        }

        protected override void UpdateRenderModel(IGameplayModel model)
        {
            _levelText.text = model.questionNumber;
            _questionText.text = model.question;
            _answer1Button.GetComponentInChildren<TextMeshProUGUI>().text = model.answer1;
            _answer2Button.GetComponentInChildren<TextMeshProUGUI>().text = model.answer2;
            _answer3Button.GetComponentInChildren<TextMeshProUGUI>().text = model.answer3;
        }
    }
}

