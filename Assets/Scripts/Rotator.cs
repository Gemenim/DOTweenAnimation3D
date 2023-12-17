using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speedRotate;

    private Vector3 _target = new Vector3(0, 180, 0);

    private void Start()
    {
        transform.DORotate(_target, _speedRotate).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }
}
