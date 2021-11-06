using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using FMODUnity;

public class Battle_Select_For_List : MonoBehaviour
{


    //������ �������� Ŭ���� ���� => ���̺� ������ Ȱ�� �ʿ�
    private int StageSelect = 0;                //�������� ���� ����
    private int SelectGene = 0;                 //������ ���� ����(����â�� ���� �ʿ�)
    public GameObject PlayerData;

    public GameObject SelectVictim;             //�������� ������ ������ ĳ���� ����â
    public Button[] Stage;                      //�������� ��ư
    public Toggle[] Gene_Select;                //ĳ���� ���� ����Ʈ
    public Sprite[] Gene_List_Sprite;           //����Ʈ ����Ǹ� �ٲ� ��������Ʈ
    public Sprite[] Gene_Select_Sprite;           //����Ʈ ���õǸ� �ٲ� ��������Ʈ


    void Start()
    {
        //�ش� ���� ���ö� �Ѹո� üũ
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            Gene_Select[0].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[0];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
        {
            Gene_Select[1].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[1];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            Gene_Select[2].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[2];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            Gene_Select[3].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[3];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            Gene_Select[4].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[4];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            Gene_Select[5].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[5];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            Gene_Select[6].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[6];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            Gene_Select[7].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[7];
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        {
            Gene_Select[8].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[8];
        }

    }


    void Update()
    {

        if(PlayerData.GetComponent<SaveDataManager>()._Stage1_4 == true)        //1_4 �� Ʃ��������!!
        {
            Stage[0].gameObject.SetActive(false);
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_1 == true)
        {
            Stage[1].gameObject.SetActive(false);
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
        {
            Stage[2].gameObject.SetActive(false);
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
        {
            Stage[3].gameObject.SetActive(false);
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
        {
            Stage[4].gameObject.SetActive(false);
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
        {
            Stage[5].gameObject.SetActive(false);
        }
        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
        {
            Stage[6].gameObject.SetActive(false);
        }




    }



    public void SelectBattle_Button()       //���۹�ư �� ��ư���� �ٸ� �������� �Ҵ�
    {
        switch (StageSelect)
        {
            case 100:           //�̰� Ʃ�丮����!!!
                if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
                {
                    SceneManager.LoadScene("BattleScene1_0_For_Tutorial");
                }
                break;

            case 1:
                if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
                {
                    SceneManager.LoadScene("BattleScene1_1");
                }
                break;

            case 2:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
                {
                    SceneManager.LoadScene("BattleScene1_2");
                }
                break;

            case 3:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
                {
                    SceneManager.LoadScene("BattleScene1_3");

                }
                break;


            case 4:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
                {
                    SceneManager.LoadScene("BattleScene2_1");

                }
                break;

            case 5:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
                {
                    SceneManager.LoadScene("BattleScene2_2");
                }
                break;

            case 6:
                if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
                {
                    SceneManager.LoadScene("BattleScene2_3");
                }
                break;



        }

    }

    public void Stage1_0()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            PlayFModUI.instance.NbuttonClick();
            StageSelect = 100;
            SelectVictim.gameObject.SetActive(true);
        }
    }


    public void Stage1_1()
    {
        if (Stage[3] == true)           //4�� 1_4 ���������� Ʃ�丮�� Ȯ�� ��������
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage1_4 == true)
            {
                PlayFModUI.instance.NbuttonClick();
                StageSelect = 1;
                SelectVictim.gameObject.SetActive(true);
            }
        }
        PlayFModUI.instance.NUnknownClick();
    }

    public void Stage1_2()
    {
        if (Stage[1] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage1_2 == true)
            {
                PlayFModUI.instance.NbuttonClick();
                StageSelect = 2;
                SelectVictim.gameObject.SetActive(true);
            }
        }
        PlayFModUI.instance.NUnknownClick();
    }

    public void Stage1_3()
    {
        if (Stage[2] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage1_3 == true)
            {
                PlayFModUI.instance.NbuttonClick();
                StageSelect = 3;
                SelectVictim.gameObject.SetActive(true);
            }
        }
        PlayFModUI.instance.NUnknownClick();
    }

    //public void Stage1_4()
    //{
    //    if (Stage[3] == true)
    //    {
    //        if (PlayerData.GetComponent<SaveDataManager>()._Stage1_4 == true)
    //        {
    //            PlayFModUI.instance.NbuttonClick();
    //            StageSelect = 4;
    //            SelectVictim.gameObject.SetActive(true);
    //        }
    //    }
    //    PlayFModUI.instance.NUnknownClick();
    //}

    public void Stage2_1()
    {
        if (Stage[4] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage2_1 == true)
            {
                PlayFModUI.instance.NbuttonClick();
                StageSelect = 5;
                SelectVictim.gameObject.SetActive(true);
            }
        }
        PlayFModUI.instance.NUnknownClick();
    }

    public void Stage2_2()
    {
        if (Stage[5] == true)
        {

            if (PlayerData.GetComponent<SaveDataManager>()._Stage2_2 == true)
            {
                PlayFModUI.instance.NbuttonClick();
                StageSelect = 6;
                SelectVictim.gameObject.SetActive(true);
            }

        }
        PlayFModUI.instance.NUnknownClick();
    }

    public void Stage2_3()
    {
        if (Stage[6] == true)
        {
            if (PlayerData.GetComponent<SaveDataManager>()._Stage2_3 == true)
            {
                StageSelect = 7;
                SelectVictim.gameObject.SetActive(true);
            }
        }
        PlayFModUI.instance.NUnknownClick();
    }

    //public void Stage2_4()
    //{
    //    if (Stage[7] == true)
    //    {
    //        if (PlayerData.GetComponent<SaveDataManager>()._Stage2_4 == true)
    //        {
    //            StageSelect = 8;
    //            SelectVictim.gameObject.SetActive(true);
    //        }
    //    }

    //}


    public void Gene_List_Mush()
    {

        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            if (Gene_Select[0].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true )
            {
                PlayFModUI.instance.NKeypadMouse();
                //����â���� �����ڸ� �����ϸ�
                //�׸��� �ش� �����ڰ� Ȱ��ȭ �Ǿ��ִ� ���̶��
                Gene_Select[0].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[0];
                //���õǾ���. �׸��� �ش� ������ ��������Ʈ (���õ� ��������Ʈ) �� ��ü��
                SelectGene = 1;
            }
            else if(Gene_Select[0].isOn == false)
            {
                Gene_Select[0].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[0];
                //������ ������ ��� ��������Ʈ�� ������� �ǵ���.
                SelectGene = 0;
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }

    public void Gene_List_ConRabbit()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mush == true)
        {
            if (Gene_Select[1].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_ConRabbit == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //����â���� �����ڸ� �����ϸ�
                //�׸��� �ش� �����ڰ� Ȱ��ȭ �Ǿ��ִ� ���̶��
                Gene_Select[1].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[1];
                //���õǾ���. �׸��� �ش� ������ ��������Ʈ (���õ� ��������Ʈ) �� ��ü��
                SelectGene = 2;
            }
            else if (Gene_Select[1].isOn == false)
            {
                Gene_Select[1].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[1];
                //������ ������ ��� ��������Ʈ�� ������� �ǵ���.
                SelectGene = 0;
            }
        }
        else {
            PlayFModUI.instance.NUnknownClick();
        }
    }

    public void Gene_List_Fran()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
        {
            if (Gene_Select[2].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Fran == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //����â���� �����ڸ� �����ϸ�
                //�׸��� �ش� �����ڰ� Ȱ��ȭ �Ǿ��ִ� ���̶��
                Gene_Select[2].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[2];
                //���õǾ���. �׸��� �ش� ������ ��������Ʈ (���õ� ��������Ʈ) �� ��ü��
                SelectGene = 3;
            }
            else if (Gene_Select[2].isOn == false)
            {
                Gene_Select[2].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[2];
                //������ ������ ��� ��������Ʈ�� ������� �ǵ���.
                SelectGene = 0;
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }

    public void Gene_List_Nymph()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
        {
            if (Gene_Select[3].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Nymph == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //����â���� �����ڸ� �����ϸ�
                //�׸��� �ش� �����ڰ� Ȱ��ȭ �Ǿ��ִ� ���̶��
                Gene_Select[3].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[3];
                //���õǾ���. �׸��� �ش� ������ ��������Ʈ (���õ� ��������Ʈ) �� ��ü��
                SelectGene = 4;
            }
            else if (Gene_Select[3].isOn == false)
            {
                Gene_Select[3].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[3];
                //������ ������ ��� ��������Ʈ�� ������� �ǵ���.
                SelectGene = 0;
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }

    public void Gene_List_Manticore()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
        {
            if (Gene_Select[4].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Manticore == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //����â���� �����ڸ� �����ϸ�
                //�׸��� �ش� �����ڰ� Ȱ��ȭ �Ǿ��ִ� ���̶��
                Gene_Select[4].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[4];
                //���õǾ���. �׸��� �ش� ������ ��������Ʈ (���õ� ��������Ʈ) �� ��ü��
                SelectGene = 5;
            }
            else if (Gene_Select[4].isOn == false)
            {
                Gene_Select[4].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[4];
                //������ ������ ��� ��������Ʈ�� ������� �ǵ���.
                SelectGene = 0;
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }

    public void Gene_List_Temp_1()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
        {
            PlayFModUI.instance.NUnknownClick();
            //    if (Gene_Select[5].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_1 == true)
            //    {
            //        PlayFModUI.instance.NUnknownClick();
            //        //����â���� �����ڸ� �����ϸ�
            //        //�׸��� �ش� �����ڰ� Ȱ��ȭ �Ǿ��ִ� ���̶��
            //        //Gene_Select[5].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[5];
            //        //���õǾ���. �׸��� �ش� ������ ��������Ʈ (���õ� ��������Ʈ) �� ��ü��
            //        //SelectGene = 6;
            //    }
            //    else if (Gene_Select[5].isOn == false)
            //    {
            //        PlayFModUI.instance.NUnknownClick();
            //        //Gene_Select[5].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[5];
            //        //������ ������ ��� ��������Ʈ�� ������� �ǵ���.
            //        //SelectGene = 0;
            //    }
            //}
            //else
            //{
            //    PlayFModUI.instance.NUnknownClick();
         }
     }

    public void Gene_List_Mobidic()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
        {
            if (Gene_Select[6].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Mobidic == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //����â���� �����ڸ� �����ϸ�
                //�׸��� �ش� �����ڰ� Ȱ��ȭ �Ǿ��ִ� ���̶��
                Gene_Select[6].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[6];
                //���õǾ���. �׸��� �ش� ������ ��������Ʈ (���õ� ��������Ʈ) �� ��ü��
                SelectGene = 7;
            }
            else if(Gene_Select[6].isOn == false)
            {
                Gene_Select[6].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[6];
                //������ ������ ��� ��������Ʈ�� ������� �ǵ���.
                SelectGene = 0;
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }

    }

    public void Gene_List_TangGreece()
    {
        if (PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
        {
            if (Gene_Select[7].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_TangGreece == true)
            {
                PlayFModUI.instance.NKeypadMouse();
                //����â���� �����ڸ� �����ϸ�
                //�׸��� �ش� �����ڰ� Ȱ��ȭ �Ǿ��ִ� ���̶��
                Gene_Select[7].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[7];
                //���õǾ���. �׸��� �ش� ������ ��������Ʈ (���õ� ��������Ʈ) �� ��ü��
                SelectGene = 8;
            }
            else if(Gene_Select[7].isOn == false)
            {
                Gene_Select[7].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[7];
                //������ ������ ��� ��������Ʈ�� ������� �ǵ���.
                SelectGene = 0;
            }
        }
        else
        {
            PlayFModUI.instance.NUnknownClick();
        }
    }

    public void Gene_List_Temp_2()
    {
        PlayFModUI.instance.NUnknownClick();

        //if (PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        //{
        //    if (Gene_Select[8].isOn && PlayerData.GetComponent<SaveDataManager>()._Creature_Temp_2 == true)
        //    {
        //        PlaySoundEvent_keypad();
        //        //����â���� �����ڸ� �����ϸ�
        //        //�׸��� �ش� �����ڰ� Ȱ��ȭ �Ǿ��ִ� ���̶��
        //        Gene_Select[8].gameObject.GetComponent<Image>().sprite = Gene_Select_Sprite[8];
        //        //���õǾ���. �׸��� �ش� ������ ��������Ʈ (���õ� ��������Ʈ) �� ��ü��
        //        SelectGene = 9;
        //    }
        //    else if (Gene_Select[8].isOn == false)
        //    {
        //        Gene_Select[8].gameObject.GetComponent<Image>().sprite = Gene_List_Sprite[8];
        //        //������ ������ ��� ��������Ʈ�� ������� �ǵ���.
        //        SelectGene = 0;
        //    }
        //}
        //else {
        //    PlaySoundEvent_Unkown(); 
        //}

    }

}