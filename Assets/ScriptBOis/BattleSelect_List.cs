using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleSelect_List : MonoBehaviour
{
    public RectTransform List;      //������ ����Ʈ
    public int count;               //���� ��
    private float pos;              //����Ʈ �ΰ� ������
    private float movepos;          //�󸶳� ��������
    private bool IsScroll = false;  //�������� �ϴ��� Ȥ�� �ƴ���


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
