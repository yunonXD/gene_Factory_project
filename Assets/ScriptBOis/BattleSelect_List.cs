using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleSelect_List : MonoBehaviour
{
    public RectTransform List;      //움직일 리스트
    public int count;               //나눌 값
    private float pos;              //리스트 로걸 포지션
    private float movepos;          //얼마나 움직일지
    private bool IsScroll = false;  //움직여야 하는지 혹은 아닌지


    void Start()
    {
        pos = List.localPosition.x;
        movepos = List.rect.xMax - List.rect.xMax / count;
    }


    void Update()
    {
        
    }

    public void moveRight()
    {
        if(pos <= -1760)
        {

        }
        else
        {
            IsScroll = true;
            movepos = pos - List.rect.width / count;
            pos = movepos;
            StartCoroutine(Scroll());
        }
    }

    public void moveLeft()
    {
        if (pos >= 0)
        {

        }
        else
        {
            IsScroll = true;
            movepos = pos + List.rect.width / count;
            pos = movepos;
            StartCoroutine(Scroll());
        }
    }

    IEnumerator Scroll()
    {
        while (IsScroll)
        {
            List.localPosition = Vector2.Lerp(List.localPosition, new Vector2(movepos, 0), Time.deltaTime * 5);
            if(Vector2.Distance(List.localPosition,new Vector2(movepos,0))< 0.1f)
            {
                IsScroll = false;
            }
            yield return null;
        }
    }


}
