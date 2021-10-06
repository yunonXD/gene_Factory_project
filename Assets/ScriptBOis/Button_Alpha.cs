using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Alpha : MonoBehaviour
{


    public float AlphaThread = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThread;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
