using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveX : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _distance;

    void Start()
    {
        transform.DOMoveX(_distance, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
