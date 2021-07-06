using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScanningStick : Yoyo
{
    Yoyo parentYoyo;


    void Start()
    {
        parentYoyo = GetComponentInParent<Yoyo>();
        ScanningStickMove();
    }

    Tween ScanningStickMove()
    {
        float startPositionX = transform.localPosition.x;
        float movePositionX = startPositionX * -1;  //symmetrical coordinates

        return transform.DOLocalMoveX(movePositionX, durationMove).SetEase(parentYoyo.easeType).SetLoops(-1, LoopType.Yoyo);
    }
}
