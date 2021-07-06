using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Yoyo : MonoBehaviour
{
    public static float durationMove = 1.0f;    //second 

    public Ease easeType;

    void Start()
    {
        YoyoMove();
    }

    Tween YoyoMove()
    {
        float startPositionX = transform.localPosition.x;
        float movePositionX = startPositionX * -1;  //symmetrical coordinates

        return transform.DOLocalMoveX(movePositionX, durationMove).SetEase(easeType).SetLoops(-1, LoopType.Yoyo);
    }
}
