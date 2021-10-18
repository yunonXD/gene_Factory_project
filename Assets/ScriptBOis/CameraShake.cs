using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeTime = 0f; // �ѵ�� �ð�
    public float shakePower = 0f; // ���� ����
    public bool Shaking; //ī�޶���ũ ����ġ true����鸲
    Vector3 pos; // ī�޶���ġ��
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
