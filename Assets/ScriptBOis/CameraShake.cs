using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeTime = 0f; // 한드는 시간
    public float shakePower = 0f; // 흔드는 강도
    public bool Shaking; //카메라쉐이크 스위치 true면흔들림
    Vector3 pos; // 카메라위치값
    // Start is called before the first frame update
    public void ShakeOn()
    {

        Shaking = true;

    }



    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(0.5f, 1, 0);
            //gameObject.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Shaking)
        {
            if (shakeTime > 0)
            {


                gameObject.transform.position = pos + Random.insideUnitSphere * shakePower;

                shakeTime -= Time.deltaTime;

            }
            else
            {
                shakeTime = 0f;
                gameObject.transform.position = pos;
                Shaking = false;
            }
        }
    }

    public void AttackCameraShake(float time, float power)
    {
        shakeTime = time;
        shakePower = power;
        Shaking = true;
    }


}
