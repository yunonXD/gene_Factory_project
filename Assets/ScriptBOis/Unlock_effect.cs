using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_effect : MonoBehaviour
{
    void DestroyObj()       //캐릭터 언락시 나오는 이펙트 사용후 파기 (차피 각 버튼마다 따로 불러와서 재사용 가능)
    {
        //gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
