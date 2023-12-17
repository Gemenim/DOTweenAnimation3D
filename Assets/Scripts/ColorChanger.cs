using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Material))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Color _targetColor;
    [SerializeField] private Material _material;

    void Start()
    {
       _material.DOColor(_targetColor, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
