using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using FMODUnity;

public class Map_Icon_button : MonoBehaviour
{
    public GameObject PlayerData; //플레이어 데이터

    [Header("==언락 이펙트==")]
    public GameObject[] Unlock_Effect;
    //이펙트가 캐릭터마다 달라질 수도 있으니 나눠놓기(이펙트가 스프라이트일수도, 혹은 이펙트(파티클)일 수 도 있다~

    [Header("==언락 스크린==")]
    public GameObject[] Unlock_Screen;


    public Text Point_Check;
    public Sprite[] Gene_List_Sprite;           //리스트 언락되면 바뀔 스프라이트
    public GameObject Gene_Info_for;


    
    int point = 0;
    //포인트

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

    [Header("인디케이터창")]
    public GameObject Indicate;


    private bool checkbuttonClick = false;      //유전자 지도 우측 하단 해금 버튼을 위한 각 유전자 버튼 누른지 아닌지 확인 유무
    private int Icon_discernment = 0;           //아이콘을 누르면 해당 아이콘에 숫자가 배정됨. 숫자&&포인트 맞으면 언락 이런식으로 구현



    public void Start()
    {



    }

    public void Update()
    {

        point = PlayerData.GetComponent<SaveDataManager>()._ResearchPoint;
        Point_Check.text = "포인트 :" + point;    //화면 우측 상단에 포인트창

        ConRabbit_Load();
        Mush_Load();
        Fran_Load();
        Nymph_Load();
        Manticore_Load();
        unknown1_Load();
        Mobidic_Load();
        TangGreece_Load();
        unknow2_Load();
    }


    private void ConRabbit_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)       
            //콘래빗 불러오기
        {
            Indicate.gameObject.SetActive(true);
            BiconNoneIntel[7].gameObject.SetActive(false);
            No_Unlock_B_Icon[7].gameObject.SetActive(false);
            Unlock_B_Icon[7].gameObject.SetActive(true);
        }
    }

    private void Mush_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)        
    //머쉬 불러오기
        {
            Indicate.gameObject.transform.localPosition = new Vector3(245, -400, 0);
            BiconNoneIntel[6].gameObject.SetActive(false);
            No_Unlock_B_Icon[6].gameObject.SetActive(false);
            Unlock_B_Icon[6].gameObject.SetActive(true);
        }
    }

    private void Fran_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)       
    //프랑 쿨러오기
        {
            Indicate.gameObject.transform.localPosition = new Vector3(385, -220, 0);
            Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);
            BiconNoneIntel[8].gameObject.SetActive(false);
            No_Unlock_B_Icon[8].gameObject.SetActive(false);
            Unlock_B_Icon[8].gameObject.SetActive(true);
        }
    }

    private void Nymph_Load()
    {

        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)       
    //님프 쿨러오기
        {
            Indicate.gameObject.transform.localPosition = new Vector3(240, -50, 0);
            Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);

            BiconNoneIntel[3].gameObject.SetActive(false);
            No_Unlock_B_Icon[3].gameObject.SetActive(false);
            Unlock_B_Icon[3].gameObject.SetActive(true);
        }
    }

    private void Manticore_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)       
    //멘티코어 쿨러오기
        {
            Indicate.gameObject.transform.localPosition = new Vector3(-50, -50, 0);
            Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);

            BiconNoneIntel[4].gameObject.SetActive(false);
            No_Unlock_B_Icon[4].gameObject.SetActive(false);
            Unlock_B_Icon[4].gameObject.SetActive(true);
        }
    }

    private void unknown1_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true
    )      //6번 미정(기획서상 6번)
        {
            Indicate.gameObject.transform.localPosition = new Vector3(-190, 110, 0);
            Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);

            BiconNoneIntel[5].gameObject.SetActive(false);
            No_Unlock_B_Icon[5].gameObject.SetActive(false);
            Unlock_B_Icon[5].gameObject.SetActive(true);
        }
    }

    private void Mobidic_Load()
    {

        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)    
    //모비딕 쿨러오기
        {
            Indicate.gameObject.transform.localPosition = new Vector3(-45, 270, 0);
            Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);

            BiconNoneIntel[0].gameObject.SetActive(false);
            No_Unlock_B_Icon[0].gameObject.SetActive(false);
            Unlock_B_Icon[0].gameObject.SetActive(true);
        }
    }

    private void TangGreece_Load()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)      
    //탕그리드 쿨러오기
        {
            Indicate.gameObject.transform.localPosition = new Vector3(240, 270, 0);

            BiconNoneIntel[1].gameObject.SetActive(false);
            No_Unlock_B_Icon[1].gameObject.SetActive(false);
            Unlock_B_Icon[1].gameObject.SetActive(true);
        }
    }

    private void unknow2_Load()
    {

        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true && 
            PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true &&
            PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true &&
    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true
    )           //3번 미정(기획서상 3번)
        {
            Indicate.gameObject.SetActive(false);
            BiconNoneIntel[2].gameObject.SetActive(false);
            No_Unlock_B_Icon[2].gameObject.SetActive(false);
            Unlock_B_Icon[2].gameObject.SetActive(true);
        }
    }










    public void PointSaver()
    {
        PlayerData.GetComponent<SaveDataManager>()._ResearchPoint = point;
        Debug.Log(PlayerData.GetComponent<SaveDataManager>()._ResearchPoint + "포인트이만큼 세이브");
    }


    //--------------------------------------언락안된버튼들----------------------//


    public void ForCheck1()     //모비딕
    {        //1~9 번 온이면 각 위치마다 숫자 부여.
        if (No_Unlock_B_Icon[0].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 1;
            Debug.Log("1");

            BiconNoneIntel[0].gameObject.SetActive(true);
        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;        //숫자를 0을 줘서 포인트 가능해도 언락 안되도록
            Debug.Log("1-0");

            BiconNoneIntel[0].gameObject.SetActive(false);
        }
    }
    public void ForCheck2()     //탕그리스
    {
        if (No_Unlock_B_Icon[1].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 2;
            Debug.Log("2");

            BiconNoneIntel[1].gameObject.SetActive(true);


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("2-0");

            BiconNoneIntel[1].gameObject.SetActive(false);
        }
    }
    public void ForCheck3()     //??
    {
        if (No_Unlock_B_Icon[2].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 3;
            Debug.Log("3");

            BiconNoneIntel[2].gameObject.SetActive(true);

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("3-0");

            BiconNoneIntel[2].gameObject.SetActive(false);
        }
    }
    public void ForCheck4()     //님프
    {
        if (No_Unlock_B_Icon[3].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 4;
            Debug.Log("4");

            BiconNoneIntel[3].gameObject.SetActive(true);

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("4-0");

            BiconNoneIntel[3].gameObject.SetActive(false);
        }
    }
    public void ForCheck5()     //??
    {
        if (No_Unlock_B_Icon[4].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 5;
            Debug.Log("5");

            BiconNoneIntel[4].gameObject.SetActive(true);

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("5-0");

            BiconNoneIntel[4].gameObject.SetActive(false);
        }
    }
    public void ForCheck6()     //??
    {
        if (No_Unlock_B_Icon[5].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 6;
            Debug.Log("6");

            BiconNoneIntel[5].gameObject.SetActive(true);

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("6-0");

            BiconNoneIntel[5].gameObject.SetActive(false);
        }
    }
    public void ForCheck7()     //머쉬
    {        //1~9 번 온이면 각 위치마다 숫자 부여.

        if (No_Unlock_B_Icon[6].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 7;
            //Bicon7Intel.gameObject.SetActive(true); //언락 안되어있을시 나오는 정보창 아직 구현 안함
            Debug.Log("7");


            BiconNoneIntel[6].gameObject.SetActive(true);

        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;        //숫자를 0을 줘서 포인트 가능해도 언락 안되도록
            Debug.Log("7-0");

            BiconNoneIntel[6].gameObject.SetActive(false);
        }
    }
    public void ForCheck8()     //콘래빗
    {
        if (No_Unlock_B_Icon[7].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 8;
            Debug.Log("8");

            BiconNoneIntel[7].gameObject.SetActive(true);


        }
        else
        {
            checkbuttonClick = false;
            Icon_discernment = 0;
            Debug.Log("8-0");

            BiconNoneIntel[7].gameObject.SetActive(false);
        }
    }
    public void ForCheck9()     //프랑
    {
        if (No_Unlock_B_Icon[8].isOn)
        {
            checkbuttonClick = true;
            Icon_discernment = 9;
            Debug.Log("9");

            BiconNoneIntel[8].gameObject.SetActive(true);

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
            case 1:     //모디빅
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
                //해금버튼 On 그리고 왼쪽 유전자 체크버튼(그니까... 중간단계까지 언락 했으면)으로 숫저2라면
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(-45, 270, 0);
                    Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();

                    BiconNoneIntel[0].gameObject.SetActive(false);          //인텔 아이콘 비활성화
                    No_Unlock_B_Icon[0].gameObject.SetActive(false);        //? 스프라이트 비활성화
                    Unlock_B_Icon[0].gameObject.SetActive(true);            //캐릭터 얼굴 스프라이트 활성화

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic = true;        //세이브 데이터 연동. 모디빅 set false -> true

                    Unlock_Effect[0].SetActive(true);                       //이팩트 활성화 (자동 destroy)

                    StartCoroutine(WaitForUnlock_Screen(0));                //언락시 나오는 언락했어요! 스크린. 코루틴 

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;
            case 2:     //탕그리스
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(240, 270, 0);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();

                    BiconNoneIntel[1].gameObject.SetActive(false);
                    No_Unlock_B_Icon[1].gameObject.SetActive(false);
                    Unlock_B_Icon[1].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece = true;

                    Unlock_Effect[1].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(1));

                    point = point - 3;
                    Point_Check.text = "포인트 :"+ point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;
            case 3:     //??
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
                {
                    Indicate.gameObject.SetActive(false);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[2].gameObject.SetActive(false);
                    No_Unlock_B_Icon[2].gameObject.SetActive(false);
                    Unlock_B_Icon[2].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 = true;

                    Unlock_Effect[2].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(2));

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }

                break;

            //4~5번 가운대줄 4 5 6
            case 4:     //님프
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(240, -50, 0);
                    Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[3].gameObject.SetActive(false);
                    No_Unlock_B_Icon[3].gameObject.SetActive(false);
                    Unlock_B_Icon[3].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph = true;

                    Unlock_Effect[3].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(3));

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

            case 5:     //만티코어
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(-50, -50, 0);
                    Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 180);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[4].gameObject.SetActive(false);
                    No_Unlock_B_Icon[4].gameObject.SetActive(false);
                    Unlock_B_Icon[4].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore = true;

                    Unlock_Effect[4].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(4));


                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

            case 6:     //??
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(-190, 110, 0);
                    Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[5].gameObject.SetActive(false);
                    No_Unlock_B_Icon[5].gameObject.SetActive(false);
                    Unlock_B_Icon[5].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 = true;

                    Unlock_Effect[5].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(5));


                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

            // 7~ 9번 맨 아래줄  7 8 9
            case 7:     //머쉬
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
                {

                    Indicate.gameObject.transform.localPosition = new Vector3(245, -400, 0);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[6].gameObject.SetActive(false);
                    No_Unlock_B_Icon[6].gameObject.SetActive(false);
                    Unlock_B_Icon[6].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Mush = true;

                    Unlock_Effect[6].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(6));

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

            case 8:     //콘래빗
                if (checkbuttonClick == true && point >= 3)
                {
                    Indicate.gameObject.SetActive(true);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[7].gameObject.SetActive(false);
                    No_Unlock_B_Icon[7].gameObject.SetActive(false);
                    Unlock_B_Icon[7].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit = true;

                    Unlock_Effect[7].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(7));

                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    PointSaver();
                    checkbuttonClick = false;
                }
                break;

            case 9:     //프랑
                if (checkbuttonClick == true && point >= 3 && PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
                {
                    Indicate.gameObject.transform.localPosition = new Vector3(385, -220, 0);
                    Indicate.gameObject.transform.localRotation = Quaternion.Euler(0, 0, 90);

                    PlayFModUI.instance.Play_Unlock_Effect();
                    PlayFModUI.instance.GeneDocument();
                    BiconNoneIntel[8].gameObject.SetActive(false);
                    No_Unlock_B_Icon[8].gameObject.SetActive(false);
                    Unlock_B_Icon[8].gameObject.SetActive(true);

                    PlayerData.GetComponent<SaveDataManager>()._Creature_Fran = true;

                    Unlock_Effect[8].SetActive(true);

                    StartCoroutine(WaitForUnlock_Screen(8));


                    point = point - 3;
                    Point_Check.text = "포인트 :" + point;
                    PointSaver();
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

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[5];


        }
        else
        {
            BiconIntelSus_L[0].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus2()
    {
        if (BiconIntel_L[1].isOn)
        {
            BiconIntelSus_L[1].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[6];




        }
        else
        {
            BiconIntelSus_L[1].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus3()
    {
        if (BiconIntel_L[2].isOn)
        {
            BiconIntelSus_L[2].gameObject.SetActive(true);

            //Gene_Info_for.gameObject.SetActive(true);



        }
        else
        {
            BiconIntelSus_L[2].gameObject.SetActive(false);
            //Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus4()
    {
        if (BiconIntel_L[3].isOn)
        {
            BiconIntelSus_L[3].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[3];



        }
        else
        {
            BiconIntelSus_L[3].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus5()
    {
        if (BiconIntel_L[4].isOn)
        {
            BiconIntelSus_L[4].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[4];


        }
        else
        {
            BiconIntelSus_L[4].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus6()
    {
        if (BiconIntel_L[5].isOn)
        {
            BiconIntelSus_L[5].gameObject.SetActive(true);

            //Gene_Info_for.gameObject.SetActive(true);



        }
        else
        {
            BiconIntelSus_L[5].gameObject.SetActive(false);
            //Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus7()
    {
        if (BiconIntel_L[6].isOn)
        {
            BiconIntelSus_L[6].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[1];



        }
        else
        {
            BiconIntelSus_L[6].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus8()
    {
        if (BiconIntel_L[7].isOn)
        {
            BiconIntelSus_L[7].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[0];


        }
        else
        {
            BiconIntelSus_L[7].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }

    public void IntelForSus9()
    {
        if (BiconIntel_L[8].isOn)
        {
            BiconIntelSus_L[8].gameObject.SetActive(true);

            Gene_Info_for.gameObject.SetActive(true);
            Gene_Info_for.gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[2];


        }
        else
        {
            BiconIntelSus_L[8].gameObject.SetActive(false);
            Gene_Info_for.gameObject.SetActive(false);

        }
    }



}
