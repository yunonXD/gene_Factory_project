using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_Icon_button : MonoBehaviour
{
    public GameObject Unlock_Effect7, Unlock_Effect8, Unlock_Effect9; 
    //이펙트가 캐릭터마다 달라질 수 도 있으니 나눠놓기(이펙트가 스프라이트일수도, 혹은 이펙트(파티클)일 수 도 있다~

    
    public Text Point_Check;        //포인트 ( 화면에 표시할 포인트 : 창 불러오기)
    int point = 10;                 //포인트 ( 기본 10포인트. 언락시 필요 포인트 3)

    //솔직히 배열로 만들어도 괜찮긴한데... 
    public Toggle Bicon1, Bicon2, Bicon3, Bicon4, Bicon5, Bicon6, Bicon7, Bicon8, Bicon9;
    public Toggle B_Bicon1, B_Bicon2, B_Bicon3, B_Bicon4, B_Bicon5, B_Bicon6, B_Bicon7, B_Bicon8, B_Bicon9;
    public Button Unlock_Button;
    public GameObject BiconNoneIntel,Bicon1Intel, Bicon2Intel, Bicon3Intel, Bicon4Intel, Bicon5Intel,
        Bicon6Intel, Bicon7Intel, Bicon8Intel, Bicon9Intel;

    private bool checkbuttonClick = false;      //유전자 지도 우측 하단 해금 버튼을 위한 각 유전자 버튼 누른지 아닌지 확인 유무
    private int Icon_discernment = 0;           //아이콘을 누르면 해당 아이콘에 숫자가 배정됨. 숫자&&포인트 맞으면 언락 이런식으로 구현
    private int LeftgeneChecker = 0;            //왼쪽줄 유전자 언락 유무(아래부터 차근차근 언락
    private int MiddlegeneChecker = 0;          //가운데줄 유전자 언락 유무(아래부터 차근차근 언락
    private int RightgeneChecker = 0;           //오른쪽줄 유전자 언락 유무(아래부터 차근차근 언락


    public void Start()
    {
        Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
        Debug.Log(NoneIntelVector);
        Point_Check.text = "포인트 :" + point;    //화면 우측 상단에 포인트창(임시)
    }

    public void ForCheck1()
    {        //1~9 번 온이면 각 위치마다 숫자 부여.
        if (B_Bicon1.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon1.isOn) Icon_discernment = 1;
            Debug.Log("1");

            Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            BiconNoneIntel.gameObject.SetActive(true); //-257.8 , 227.5 , 0.0
            NoneIntelVector.x = -257.8f;
            NoneIntelVector.y = 227.5f;
            BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon1.isOn) Icon_discernment = 0;        //숫자를 0을 줘서 포인트 가능해도 언락 안되도록
            Debug.Log("1-0");

            BiconNoneIntel.gameObject.SetActive(false);
        }
    }
    public void ForCheck2() 
    { 
        if (B_Bicon2.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon2.isOn) Icon_discernment = 2;
            Debug.Log("2");

            Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            BiconNoneIntel.gameObject.SetActive(true); //150.7 , 227.5 , 0.0
            NoneIntelVector.x = 150.7f;
            NoneIntelVector.y = 227.5f;
            BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon2.isOn) Icon_discernment = 0;
            Debug.Log("2-0");

            BiconNoneIntel.gameObject.SetActive(false);
        }
    }
    public void ForCheck3()
    {
        if (B_Bicon3.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon3.isOn) Icon_discernment = 3;
            Debug.Log("3");

            Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            BiconNoneIntel.gameObject.SetActive(true); //565.4 , 227.5 , 0.0
            NoneIntelVector.x = 565.4f;
            NoneIntelVector.y = 227.5f;
            BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon3.isOn) Icon_discernment = 0;
            Debug.Log("3-0");

            BiconNoneIntel.gameObject.SetActive(false);
        }
    }
    public void ForCheck4()
    {
        if (B_Bicon4.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon4.isOn) Icon_discernment = 4;
            Debug.Log("4");

            Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            BiconNoneIntel.gameObject.SetActive(true); //-267.8 , -86.9 , 0.0
            NoneIntelVector.x = -267.8f;
            NoneIntelVector.y = -86.9f;
            BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon4.isOn) Icon_discernment = 0;
            Debug.Log("4-0");

            BiconNoneIntel.gameObject.SetActive(false);
        }
    }
    public void ForCheck5()
    {
        if (B_Bicon5.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon5.isOn) Icon_discernment = 5;
            Debug.Log("5");

            Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            BiconNoneIntel.gameObject.SetActive(true); //150.7 , -86.9 , 0.0
            NoneIntelVector.x = 150.7f;
            NoneIntelVector.y = -86.9f;
            BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon5.isOn) Icon_discernment = 0;
            Debug.Log("5-0");

            BiconNoneIntel.gameObject.SetActive(false);
        }
    }
    public void ForCheck6()
    {
        if (B_Bicon6.isOn)
        {
            checkbuttonClick = true;
            if (B_Bicon6.isOn) Icon_discernment = 6;
            Debug.Log("6");

            Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            BiconNoneIntel.gameObject.SetActive(true); //565.4 , -86.9 , 0.0
            NoneIntelVector.x = 565.4f;
            NoneIntelVector.y = -86.9f;
            BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else
        {
            checkbuttonClick = false;
            if (B_Bicon6.isOn) Icon_discernment = 0;
            Debug.Log("6-0");

            BiconNoneIntel.gameObject.SetActive(false);
        }
    }
    public void ForCheck7(){        //1~9 번 온이면 각 위치마다 숫자 부여.

        if (B_Bicon7.isOn){
            checkbuttonClick = true;
            if (B_Bicon7.isOn) Icon_discernment = 7;
            //Bicon7Intel.gameObject.SetActive(true); //언락 안되어있을시 나오는 정보창 아직 구현 안함
            Debug.Log("7");


            BiconNoneIntel.gameObject.SetActive(true); // -267.8 , -374.6, 0.0
            Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            NoneIntelVector.x = -267.8f;
            NoneIntelVector.y = -374.6f;
            BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else{
            checkbuttonClick = false;
            if (B_Bicon7.isOn) Icon_discernment = 0;        //숫자를 0을 줘서 포인트 가능해도 언락 안되도록
            Debug.Log("7-0");

            BiconNoneIntel.gameObject.SetActive(false);
        }
    }
    public void ForCheck8(){
        if (B_Bicon8.isOn){
            checkbuttonClick = true;
            if (B_Bicon8.isOn) Icon_discernment = 8;
            Debug.Log("8");

            Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            BiconNoneIntel.gameObject.SetActive(true); //150.7 , -374.6 , 0.0
            NoneIntelVector.x = 150.7f;
            NoneIntelVector.y = -374.6f;
            BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else{
            checkbuttonClick = false;
            if (B_Bicon8.isOn) Icon_discernment = 0;
            Debug.Log("8-0");

            BiconNoneIntel.gameObject.SetActive(false);
        }
    }
    public void ForCheck9(){
        if (B_Bicon9.isOn){
            checkbuttonClick = true;
            if (B_Bicon9.isOn) Icon_discernment = 9;
            Debug.Log("9");


            Vector3 NoneIntelVector = BiconNoneIntel.transform.localPosition;
            BiconNoneIntel.gameObject.SetActive(true); //565.4 , -374.6 , 0.0
            NoneIntelVector.x = 565.4f;
            NoneIntelVector.y = -374.6f;
            BiconNoneIntel.transform.localPosition = NoneIntelVector;
        }
        else{
            checkbuttonClick = false;
            if (B_Bicon9.isOn) Icon_discernment = 0;
            Debug.Log("9-0");

            BiconNoneIntel.gameObject.SetActive(false);
        }
    }



    public void Unlock_ButtonPress()        //위에 ForCheck[] 에서 부여받은 숫자로 해금버튼 활성화
    {

        switch (Icon_discernment)
        {

            // 1~3번 맨 윗줄 1 2 3
            case 1:
                if (checkbuttonClick == true && point > 3 && LeftgeneChecker == 2)
                {
                    BiconNoneIntel.gameObject.SetActive(false);
                    B_Bicon1.gameObject.SetActive(false);
                    Bicon1.gameObject.SetActive(true);
                    //Unlock_Effect1.SetActive(true);

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                }
                break;
            case 2:
                if (checkbuttonClick == true && point > 3 && MiddlegeneChecker == 2)
                {
                    BiconNoneIntel.gameObject.SetActive(false);
                    B_Bicon2.gameObject.SetActive(false);
                    Bicon2.gameObject.SetActive(true);
                    //Unlock_Effect1.SetActive(true);

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                }
                break;
            case 3:
                if (checkbuttonClick == true && point > 3 && RightgeneChecker == 2)
                {
                    BiconNoneIntel.gameObject.SetActive(false);
                    B_Bicon1.gameObject.SetActive(false);
                    Bicon1.gameObject.SetActive(true);
                    //Unlock_Effect1.SetActive(true);

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                }
                break;

                //4~5번 가운대줄 4 5 6
            case 4:
                if(checkbuttonClick == true && point > 3 && LeftgeneChecker == 1)
                {
                    BiconNoneIntel.gameObject.SetActive(false);
                    B_Bicon4.gameObject.SetActive(false);
                    Bicon4.gameObject.SetActive(true);
                    //Unlock_Effect4.SetActive(true);

                    LeftgeneChecker = 2;

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                }
                else
                {
                    Debug.Log("포인트부족");
                    return;
                }
                break;

            case 5:
                if (checkbuttonClick == true && point > 3 && MiddlegeneChecker == 1)
                {
                    BiconNoneIntel.gameObject.SetActive(false);
                    B_Bicon5.gameObject.SetActive(false);
                    Bicon5.gameObject.SetActive(true);
                    //Unlock_Effect5.SetActive(true);

                    MiddlegeneChecker = 2;

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                }
                else
                {
                    Debug.Log("포인트부족");
                    return;
                }

                break;
            case 6:
                if (checkbuttonClick == true && point > 3 && RightgeneChecker == 1)
                {
                    BiconNoneIntel.gameObject.SetActive(false);
                    B_Bicon6.gameObject.SetActive(false);
                    Bicon6.gameObject.SetActive(true);
                    //Unlock_Effect6.SetActive(true);

                    RightgeneChecker = 2;

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                }
                else
                {
                    Debug.Log("포인트부족");
                    return;
                }


                break;

                // 7~ 9번 맨 아래줄  7 8 9
            case 7:
                if (checkbuttonClick == true && point > 3)
                {
                    BiconNoneIntel.gameObject.SetActive(false);
                    B_Bicon7.gameObject.SetActive(false);
                    Bicon7.gameObject.SetActive(true);
                    //Unlock_Effect7.SetActive(true);

                    LeftgeneChecker = 1;

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                }
                else
                {
                    Debug.Log("포인트부족");
                    return;
                }
                break;

            case 8:
                if (checkbuttonClick == true && point > 3)
                {
                    BiconNoneIntel.gameObject.SetActive(false);
                    B_Bicon8.gameObject.SetActive(false);
                    Bicon8.gameObject.SetActive(true);
                    //Unlock_Effect8.SetActive(true);

                    MiddlegeneChecker = 1;

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                }
                else
                {
                    Debug.Log("포인트부족");
                    return;
                }
                break;

            case 9:
                if (checkbuttonClick == true && point > 3)
                {
                    BiconNoneIntel.gameObject.SetActive(false);
                    B_Bicon9.gameObject.SetActive(false);
                    Bicon9.gameObject.SetActive(true);
                    //Unlock_Effect9.SetActive(true);

                    RightgeneChecker = 1;

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                }
                else
                {
                    Debug.Log("포인트부족");
                    return;
                }
                break;
        }

    }

}
