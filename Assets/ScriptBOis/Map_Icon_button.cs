using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;

//해야하는거 - 이펙트 위치 수정, no information 창 팝업 수정 , 언락시 팝업창 생성하기


public class Map_Icon_button : MonoBehaviour
{
    [Header("==언락 이펙트==")]
    public GameObject[] Unlock_Effect;
    //이펙트가 캐릭터마다 달라질 수도 있으니 나눠놓기(이펙트가 스프라이트일수도, 혹은 이펙트(파티클)일 수 도 있다~

    [Header("==언락 스크린==")]
    public GameObject[] Unlock_Screen;



    public Text Gene_Name, Gene_Intel, Point_Check;
    [Space]
    public GameObject Gene_Intel_Text;

    //Gene_Intel_Text부분 유전자 이름,정보, 세부사항 
    //포인트 ( 화면에 표시할 포인트 : 창 불러오기) 

    int point = 99;
    //포인트 ( 기본 30포인트. 언락시 필요 포인트 3)

    [Header("==언락 안된 큰 아이콘==")]
    public Toggle[] No_Unlock_B_Icon;


    [Header("==언락된 큰 아이콘==")]
    public Toggle[] Unlock_B_Icon;


    [Space]
    public Button Unlock_Button;        //우측 하단 언락 버튼

    [Header("==왼쪽 작~은 정보 팝업창==")]
    public Toggle[] BiconIntel_L;

    [Header("==왼쪽 큰 정보 팝업창==")]
    public Toggle[] BiconIntelSus_L;

    [Header("==언락 안되어있을시 나오는 작은 인텔창==")]
    public GameObject[] BiconNoneIntel;


    [Header("==작은 유전자==")]
    public Toggle[] Small_Icon;

    [Header("==언락된 작은 유전자==")]
    public GameObject[] Unlock_Small_Icon;

    //Sprite[] sprites = Resources.LoadAll<Sprite>("Sprites/Gene_Resource/GMAP_mini_1");

    private bool checkbuttonClick = false;      //유전자 지도 우측 하단 해금 버튼을 위한 각 유전자 버튼 누른지 아닌지 확인 유무
    private int Icon_discernment = 0;           //아이콘을 누르면 해당 아이콘에 숫자가 배정됨. 숫자&&포인트 맞으면 언락 이런식으로 구현


    private int LeftgeneChecker = 0;            //왼쪽줄 유전자 언락 유무(아래부터 차근차근 언락
    private int MiddlegeneChecker = 0;          //가운데줄 유전자 언락 유무(아래부터 차근차근 언락
    private int RightgeneChecker = 0;           //오른쪽줄 유전자 언락 유무(아래부터 차근차근 언락


    public void Start()
    {
        //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
        //Debug.Log(NoneIntelVector);
        Point_Check.text = "포인트 :" + point;    //화면 우측 상단에 포인트창(임시)
    }

    //--------------------------------------언락안된버튼들----------------------//


    public void ForCheck1()
    {        //1~9 번 온이면 각 위치마다 숫자 부여.
        if (No_Unlock_B_Icon[0].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 1;
            Debug.Log("1");

            BiconNoneIntel[0].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //-257.8 , 227.5 , 0.0
            //NoneIntelVector.x = -257.8f;
            //NoneIntelVector.y = 227.5f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;        //숫자를 0을 줘서 포인트 가능해도 언락 안되도록
            Debug.Log("1-0");

            BiconNoneIntel[0].gameObject.SetActive(false);
        }
    }
    public void ForCheck2()
    {
        if (No_Unlock_B_Icon[1].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 2;
            Debug.Log("2");

            BiconNoneIntel[1].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //150.7 , 227.5 , 0.0
            //NoneIntelVector.x = 150.7f;
            //NoneIntelVector.y = 227.5f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("2-0");

            BiconNoneIntel[1].gameObject.SetActive(false);
        }
    }
    public void ForCheck3()
    {
        if (No_Unlock_B_Icon[2].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 3;
            Debug.Log("3");

            BiconNoneIntel[2].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //565.4 , 227.5 , 0.0
            //NoneIntelVector.x = 565.4f;
            //NoneIntelVector.y = 227.5f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("3-0");

            BiconNoneIntel[2].gameObject.SetActive(false);
        }
    }
    public void ForCheck4()
    {
        if (No_Unlock_B_Icon[3].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 4;
            Debug.Log("4");

            BiconNoneIntel[3].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //-267.8 , -86.9 , 0.0
            //NoneIntelVector.x = -267.8f;
            //NoneIntelVector.y = -86.9f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("4-0");

            BiconNoneIntel[3].gameObject.SetActive(false);
        }
    }
    public void ForCheck5()
    {
        if (No_Unlock_B_Icon[4].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 5;
            Debug.Log("5");

            BiconNoneIntel[4].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //150.7 , -86.9 , 0.0
            //NoneIntelVector.x = 150.7f;
            //NoneIntelVector.y = -86.9f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("5-0");

            BiconNoneIntel[4].gameObject.SetActive(false);
        }
    }
    public void ForCheck6()
    {
        if (No_Unlock_B_Icon[5].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 6;
            Debug.Log("6");

            BiconNoneIntel[5].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //565.4 , -86.9 , 0.0
            //NoneIntelVector.x = 565.4f;
            //NoneIntelVector.y = -86.9f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("6-0");

            BiconNoneIntel[5].gameObject.SetActive(false);
        }
    }
    public void ForCheck7()
    {        //1~9 번 온이면 각 위치마다 숫자 부여.

        if (No_Unlock_B_Icon[6].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 7;
            //Bicon7Intel.gameObject.SetActive(true); //언락 안되어있을시 나오는 정보창 아직 구현 안함
            Debug.Log("7");

            BiconNoneIntel[6].gameObject.SetActive(true);



            //BiconNoneIntel.gameObject.SetActive(true); // -267.8 , -374.6, 0.0
            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //NoneIntelVector.x = -267.8f;
            //NoneIntelVector.y = -374.6f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;        //숫자를 0을 줘서 포인트 가능해도 언락 안되도록
            Debug.Log("7-0");

            BiconNoneIntel[6].gameObject.SetActive(false);
        }
    }
    public void ForCheck8()
    {
        if (No_Unlock_B_Icon[7].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 8;
            Debug.Log("8");

            BiconNoneIntel[7].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //150.7 , -374.6 , 0.0
            //NoneIntelVector.x = 150.7f;
            //NoneIntelVector.y = -374.6f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("8-0");

            BiconNoneIntel[7].gameObject.SetActive(false);
        }
    }
    public void ForCheck9()
    {
        if (No_Unlock_B_Icon[8].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 9;
            Debug.Log("9");

            BiconNoneIntel[8].gameObject.SetActive(true);


            //Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            //BiconNoneIntel.gameObject.SetActive(true); //565.4 , -374.6 , 0.0
            //NoneIntelVector.x = 565.4f;
            //NoneIntelVector.y = -374.6f;
            //BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            Icon_discernment = 0;
            checkbuttonClick = false;
            Debug.Log("9-0");
            BiconNoneIntel[8].gameObject.SetActive(false);
        }
    }


    //--------------------------------------언락버튼----------------------//

    public void Unlock_ButtonPress()        //위에 ForCheck[] 에서 부여받은 숫자로 해금버튼 활성화
    {

        switch (Icon_discernment)
        {

            // 1~3번 맨 윗줄 1 2 3
            case 1:
                if (checkbuttonClick == true && point > 3 && LeftgeneChecker == 2)
                //해금버튼 On 그리고 왼쪽 유전자 체크버튼(그니까... 중간단계까지 언락 했으면)으로 숫저2라면
                {
                    BiconNoneIntel[0].gameObject.SetActive(false); //인텔 아이콘 비활성화
                    No_Unlock_B_Icon[0].gameObject.SetActive(false);       //? 스프라이트 비활성화
                    Unlock_B_Icon[0].gameObject.SetActive(true);          //캐릭터 얼굴 스프라이트 활성화

                    Unlock_Effect[0].SetActive(true);             //이팩트 활성화 (자동 destroy)

                    StartCoroutine(WaitForUnlock_Screen(0));        //언락시 나오는 언락했어요! 스크린. 코루틴 

                    point = point - 5;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;
            case 2:
                if (checkbuttonClick == true && point > 3 && MiddlegeneChecker == 2)
                {
                    BiconNoneIntel[1].gameObject.SetActive(false);
                    No_Unlock_B_Icon[1].gameObject.SetActive(false);
                    Unlock_B_Icon[1].gameObject.SetActive(true);
                    Unlock_Effect[1].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(1));

                    point = point - 5;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;
            case 3:
                if (checkbuttonClick == true && point > 3 && RightgeneChecker == 2)
                {
                    BiconNoneIntel[2].gameObject.SetActive(false);
                    No_Unlock_B_Icon[2].gameObject.SetActive(false);
                    Unlock_B_Icon[2].gameObject.SetActive(true);
                    Unlock_Effect[2].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(2));

                    point = point - 5;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }

                break;

            //4~5번 가운대줄 4 5 6
            case 4:
                if (checkbuttonClick == true && point > 3 && LeftgeneChecker == 1)
                {
                    BiconNoneIntel[3].gameObject.SetActive(false);
                    No_Unlock_B_Icon[3].gameObject.SetActive(false);
                    Unlock_B_Icon[3].gameObject.SetActive(true);
                    Unlock_Effect[3].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(3));

                    LeftgeneChecker = 2;

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 5:
                if (checkbuttonClick == true && point > 3 && MiddlegeneChecker == 1)
                {
                    BiconNoneIntel[4].gameObject.SetActive(false);
                    No_Unlock_B_Icon[4].gameObject.SetActive(false);
                    Unlock_B_Icon[4].gameObject.SetActive(true);
                    Unlock_Effect[4].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(4));

                    MiddlegeneChecker = 2;

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;
            case 6:
                if (checkbuttonClick == true && point > 3 && RightgeneChecker == 1)
                {
                    BiconNoneIntel[5].gameObject.SetActive(false);
                    No_Unlock_B_Icon[5].gameObject.SetActive(false);
                    Unlock_B_Icon[5].gameObject.SetActive(true);
                    Unlock_Effect[5].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(5));

                    RightgeneChecker = 2;

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

            // 7~ 9번 맨 아래줄  7 8 9
            case 7:
                if (checkbuttonClick == true && point > 3)
                {
                    BiconNoneIntel[6].gameObject.SetActive(false);
                    No_Unlock_B_Icon[6].gameObject.SetActive(false);
                    Unlock_B_Icon[6].gameObject.SetActive(true);
                    Unlock_Effect[6].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(6));



                    LeftgeneChecker = 1;

                    point = point - 2;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 8:
                if (checkbuttonClick == true && point > 3)
                {
                    BiconNoneIntel[7].gameObject.SetActive(false);
                    No_Unlock_B_Icon[7].gameObject.SetActive(false);
                    Unlock_B_Icon[7].gameObject.SetActive(true);
                    Unlock_Effect[7].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(7));

                    MiddlegeneChecker = 1;

                    point = point - 2;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 9:
                if (checkbuttonClick == true && point > 3)
                {
                    BiconNoneIntel[8].gameObject.SetActive(false);
                    No_Unlock_B_Icon[8].gameObject.SetActive(false);
                    Unlock_B_Icon[8].gameObject.SetActive(true);
                    Unlock_Effect[8].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(8));

                    RightgeneChecker = 1;

                    point = point - 2;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 10:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[3].gameObject.activeSelf == true)
                {
                    Small_Icon[0].gameObject.SetActive(false);
                    Unlock_Small_Icon[0].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 11:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[3].gameObject.activeSelf == true && Unlock_B_Icon[4].gameObject.activeSelf == true)
                {
                    Small_Icon[1].gameObject.SetActive(false);
                    Unlock_Small_Icon[1].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 12:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[4].gameObject.activeSelf == true && Unlock_B_Icon[5].gameObject.activeSelf == true)
                {
                    Small_Icon[2].gameObject.SetActive(false);
                    Unlock_Small_Icon[2].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 13:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[5].gameObject.activeSelf == true)
                {
                    Small_Icon[3].gameObject.SetActive(false);
                    Unlock_Small_Icon[3].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 14:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[6].gameObject.activeSelf == true)
                {
                    Small_Icon[4].gameObject.SetActive(false);
                    Unlock_Small_Icon[4].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;


            case 15:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[6].gameObject.activeSelf == true && Unlock_B_Icon[7].gameObject.activeSelf == true)
                {
                    Small_Icon[5].gameObject.SetActive(false);
                    Unlock_Small_Icon[5].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;


            case 16:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[7].gameObject.activeSelf == true && Unlock_B_Icon[8].gameObject.activeSelf == true)
                {
                    Small_Icon[6].gameObject.SetActive(false);
                    Unlock_Small_Icon[6].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

            case 17:
                if (checkbuttonClick == true && point > 1 && Unlock_B_Icon[8].gameObject.activeSelf == true)
                {
                    Small_Icon[7].gameObject.SetActive(false);
                    Unlock_Small_Icon[7].gameObject.SetActive(true);



                    point = point - 1;
                    Point_Check.text = "포인트 :" + point;
                    checkbuttonClick = false;
                }
                break;

        }

    }

    // ----------------------------- 언락시 스크린 나오는거 ----------------------------- 프로토타입. 하나만 구현
    IEnumerator WaitForUnlock_Screen(int checker)
    {
        yield return new WaitForSeconds(0.7f);
        Unlock_Screen[checker].gameObject.SetActive(true);

    }


    //--------------------------------------큰 아이콘 클릭시 열려있는 다른 인텔창 닫기 버튼----------------------//
    public void IntelChecker1()
    {
        if (Unlock_B_Icon[0].isOn)
        {
            BiconIntel_L[0].gameObject.SetActive(true);

            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;

            //GameObject.Find("Gene_Intel_Text").SetActive(false);

            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[0].gameObject.SetActive(false);
            BiconIntel_L[0].isOn = false;

        }
    }
    public void IntelChecker2()
    {
        if (Unlock_B_Icon[1].isOn)
        {
            BiconIntel_L[1].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[1].gameObject.SetActive(false);
            BiconIntel_L[1].isOn = false;
        }
    }
    public void IntelChecker3()
    {
        if (Unlock_B_Icon[2].isOn)
        {
            BiconIntel_L[2].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[2].gameObject.SetActive(false);
            BiconIntel_L[2].isOn = false;
        }
    }

    public void IntelChecker4()
    {
        if (Unlock_B_Icon[3].isOn)
        {
            BiconIntel_L[3].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[3].gameObject.SetActive(false);
            BiconIntel_L[3].isOn = false;
        }
    }

    public void IntelChecker5()
    {
        if (Unlock_B_Icon[4].isOn)
        {
            BiconIntel_L[4].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[4].gameObject.SetActive(false);
            BiconIntel_L[4].isOn = false;
        }
    }

    public void IntelChecker6()
    {
        if (Unlock_B_Icon[5].isOn)
        {
            BiconIntel_L[5].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[5].gameObject.SetActive(false);
            BiconIntel_L[5].isOn = false;
        }
    }

    public void IntelChecker7()
    {
        if (Unlock_B_Icon[6].isOn)
        {
            BiconIntel_L[6].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[7].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[7].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[6].gameObject.SetActive(false);
            BiconIntel_L[6].isOn = false;
        }
    }

    public void IntelChecker8()
    {
        if (Unlock_B_Icon[7].isOn)
        {
            BiconIntel_L[7].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[8].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[8].isOn = false;
        }
        else
        {
            BiconIntel_L[7].gameObject.SetActive(false);
            BiconIntel_L[7].isOn = false;
        }
    }

    public void IntelChecker9()
    {
        if (Unlock_B_Icon[8].isOn)
        {
            BiconIntel_L[8].gameObject.SetActive(true);

            Unlock_B_Icon[0].isOn = false;
            Unlock_B_Icon[1].isOn = false;
            Unlock_B_Icon[2].isOn = false;
            Unlock_B_Icon[3].isOn = false;
            Unlock_B_Icon[4].isOn = false;
            Unlock_B_Icon[5].isOn = false;
            Unlock_B_Icon[6].isOn = false;
            Unlock_B_Icon[7].isOn = false;


            BiconIntel_L[0].isOn = false;
            BiconIntel_L[1].isOn = false;
            BiconIntel_L[2].isOn = false;
            BiconIntel_L[3].isOn = false;
            BiconIntel_L[4].isOn = false;
            BiconIntel_L[5].isOn = false;
            BiconIntel_L[6].isOn = false;
            BiconIntel_L[7].isOn = false;
        }
        else
        {
            BiconIntel_L[8].gameObject.SetActive(false);
            BiconIntel_L[8].isOn = false;
        }
    }


    //--------------------------------------정보창 클릭시 왼쪽에 나오는 큰 정보창 및 이름 세부사항 버튼----------------------//

    public void IntelForSus1()
    {
        if (BiconIntel_L[0].isOn)
        {
            BiconIntelSus_L[0].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "모비딕";

            Gene_Intel.text = "1번 정보";


        }
        else
        {
            BiconIntelSus_L[0].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus2()
    {
        if (BiconIntel_L[1].isOn)
        {
            BiconIntelSus_L[1].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "탕그리스";

            Gene_Intel.text = "2번 정보";


        }
        else
        {
            BiconIntelSus_L[1].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus3()
    {
        if (BiconIntel_L[2].isOn)
        {
            BiconIntelSus_L[2].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "3번";

            Gene_Intel.text = "3번 정보";


        }
        else
        {
            BiconIntelSus_L[2].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus4()
    {
        if (BiconIntel_L[3].isOn)
        {
            BiconIntelSus_L[3].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "님프";

            Gene_Intel.text = "4번 정보";


        }
        else
        {
            BiconIntelSus_L[3].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus5()
    {
        if (BiconIntel_L[4].isOn)
        {
            BiconIntelSus_L[4].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "만티코어";

            Gene_Intel.text = "5번 정보";


        }
        else
        {
            BiconIntelSus_L[4].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus6()
    {
        if (BiconIntel_L[5].isOn)
        {
            BiconIntelSus_L[5].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "6번";

            Gene_Intel.text = "6번 정보";


        }
        else
        {
            BiconIntelSus_L[5].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus7()
    {
        if (BiconIntel_L[6].isOn)
        {
            BiconIntelSus_L[6].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "머시";

            Gene_Intel.text = "7번 정보";


        }
        else
        {
            BiconIntelSus_L[6].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus8()
    {
        if (BiconIntel_L[7].isOn)
        {
            BiconIntelSus_L[7].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "콘래빗";

            Gene_Intel.text = "8번 정보";


        }
        else
        {
            BiconIntelSus_L[7].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }

    public void IntelForSus9()
    {
        if (BiconIntel_L[8].isOn)
        {
            BiconIntelSus_L[8].gameObject.SetActive(true);

            Gene_Intel_Text.gameObject.SetActive(true);

            Gene_Name.text = "프랑";

            Gene_Intel.text = "9번 정보";


        }
        else
        {
            BiconIntelSus_L[8].gameObject.SetActive(false);
            Gene_Intel_Text.gameObject.SetActive(false);

        }
    }




    //--------------------------------------작은 아이콘 해금 버튼----------------------//


    public void Small_Unlocker1()
    {
        if (Small_Icon[0].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 10;
            Debug.Log("S_1");


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_1");

        }
    }
    public void Small_Unlocker2()
    {
        if (Small_Icon[1].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 11;
            Debug.Log("S_2");



        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_2");

        }
    }
    public void Small_Unlocker3()
    {
        if (Small_Icon[2].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 12;
            Debug.Log("S_3");


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_3");

        }
    }

    public void Small_Unlocker4()
    {
        if (Small_Icon[3].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 13;
            Debug.Log("S_4");


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_4");

        }
    }
    public void Small_Unlocker5()
    {
        if (Small_Icon[4].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 14;
            Debug.Log("S_5");


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_5");

        }
    }

    public void Small_Unlocker6()
    {
        if (Small_Icon[5].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 15;
            Debug.Log("S_6");



        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_6");

        }
    }


    public void Small_Unlocker7()
    {
        if (Small_Icon[6].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 16;
            Debug.Log("S_7");

  

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_7");

        }
    }

    public void Small_Unlocker8()
    {
        if (Small_Icon[7].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 17;
            Debug.Log("S_8");


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("S0_8");

        }
    }
}
