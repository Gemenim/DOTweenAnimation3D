using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SizeMeter : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _scale;

    void Start()
    {
        transform.DOScale(_scale, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
