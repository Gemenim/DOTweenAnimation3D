using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class TextChange : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private string _textReplacement;
    [SerializeField] private string _textAddition;

    void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_textReplacement, _duration).SetRelative());
        sequence.Append(_text.DOText(_textAddition, _duration).SetRelative().SetRelative());
        sequence.Append(_text.DOText(_textReplacement, _duration, true, ScrambleMode.All).SetRelative());

        sequence.SetLoops(-1, LoopType.Incremental);
    }
}
