using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map_Icon_button : MonoBehaviour
{

    public GameObject Unlock_Effect7, Unlock_Effect8, Unlock_Effect9; 
    //이펙트가 캐릭터마다 달라질 수 도 있으니 나눠놓기

    
    public Text Point_Check;        //포인트 ( 화면에 표시할 포인트 : 창 불러오기)
    int point = 10;                 //포인트 ( 기본 10포인트. 언락시 필요 포인트 3)

    //솔직히 배열로 만들어도 괜찮긴한데... 
    public Toggle Bicon1, Bicon2, Bicon3, Bicon4, Bicon5, Bicon6, Bicon7, Bicon8, Bicon9;
    public Toggle B_Bicon7, B_Bicon8, B_Bicon9;
    public Button Unlock_Button;
    public GameObject  Bicon1Intel, Bicon2Intel, Bicon3Intel, Bicon4Intel, Bicon5Intel,
        Bicon6Intel, Bicon7Intel, Bicon8Intel, Bicon9Intel;

    private bool checkbuttonClick = false;      //유전자 지도 우측 하단 해금 버튼을 위한 각 유전자 버튼 누른지 아닌지 확인 유무
    private int Icon_discernment = 0;           //아이콘을 누르면 해당 아이콘에 숫자가 배정됨. 숫자&&포인트 맞으면 언락 이런식으로 구현

    public void Start()
    {
        Point_Check.text = "포인트 :" + point;    //화면 우측 상단에 포인트창
    }


    //<--------------------곧 안쓰일 예정-------------------->
    public void Bicon1Click()
    {
        if (Bicon1.isOn)
        {
            Bicon1Intel.gameObject.SetActive(true);
        }
        else
        {
            Bicon1Intel.gameObject.SetActive(false);
        }
    }

    public void Bicon2Click()
    {
        if (Bicon2.isOn){
            Bicon2Intel.gameObject.SetActive(true);
        }
        else
        {
            Bicon2Intel.gameObject.SetActive(false);
        }
    }
    //<--------------------곧 안쓰일 예정-------------------->




    public void ForCheck7(){        //1~9 번 온이면 각 위치마다 숫자 부여.
        if (B_Bicon7.isOn){
            checkbuttonClick = true;
            if (B_Bicon7.isOn) Icon_discernment = 7;
            //Bicon7Intel.gameObject.SetActive(true); //언락 안되어있을시 나오는 정보창 아직 구현 안함
            Debug.Log("7");
        }
        else{
            checkbuttonClick = false;
            if (B_Bicon7.isOn) Icon_discernment = 0;        //숫자를 0을 줘서 포인트 가능해도 언락 안되도록
            Debug.Log("7-0");
        }
    }
    public void ForCheck8(){
        if (B_Bicon8.isOn){
            checkbuttonClick = true;
            if (B_Bicon8.isOn) Icon_discernment = 8;
            Debug.Log("8");
        }
        else{
            checkbuttonClick = false;
            if (B_Bicon8.isOn) Icon_discernment = 0;
            Debug.Log("8-0");
        }
    }
    public void ForCheck9(){
        if (B_Bicon9.isOn){
            checkbuttonClick = true;
            if (B_Bicon9.isOn) Icon_discernment = 9;
            Debug.Log("9");
        }
        else{
            checkbuttonClick = false;
            if (B_Bicon9.isOn) Icon_discernment = 0;
            Debug.Log("9-0");
        }
    }



    public void Unlock_ButtonPress()        //위에 ForCheck[] 에서 부여받은 숫자로 해금버튼 활성화
    {

        switch (Icon_discernment)
        {

            // 1~3번 맨 윗줄 1 2 3
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;

                //4~5번 가운대줄 4 5 6
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
                // 7~ 9번 맨 아래줄  7 8 9
            case 7:
                if (checkbuttonClick == true && point > 3)
                {
                    B_Bicon7.gameObject.SetActive(false);
                    Bicon7.gameObject.SetActive(true);
                    Unlock_Effect7.SetActive(true);
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
                    B_Bicon8.gameObject.SetActive(false);
                    Bicon8.gameObject.SetActive(true);
                    Unlock_Effect8.SetActive(true);
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
                    B_Bicon9.gameObject.SetActive(false);
                    Bicon9.gameObject.SetActive(true);
                    Unlock_Effect9.SetActive(true);
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




    //public void BiconToggle7Click()
    //{

    //    if (Bicon7.isOn)
    //    {
    //        Bicon7Intel.gameObject.SetActive(true);
    //    }
    //    else
    //    {
    //        Bicon7Intel.gameObject.SetActive(false);
    //    }
    //}



    //IEnumerable WaitForDis()
    //{
    //    Unlock_Effect.SetActive(true);
    //    Debug.Log("Ezplode Enter");
    //    yield return new WaitForSeconds(2.0f);
    //    Bicon7.gameObject.SetActive(false);
    //    Debug.Log("Ezplode end");
    //}


    //Vector3 spawn = this.gameObject.transform.localPosition;
    //spawn.z = Unlock_Effect.gameObject.transform.localPosition.z;
    //Instantiate(Unlock_Effect, spawn, Quaternion.identity);

}
