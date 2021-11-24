using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveBlackScreen : MonoBehaviour
{
    private void Start()
    {
    }

    public void MoveR_TO_L()
    {
        transform.DOMove(new Vector3(0, 0, 0), 1);
    }

    public void MoveR_TO_L_Num2()
    {

        transform.DOMove(new Vector3(-1920, 0, 0), 1);
    }
}
