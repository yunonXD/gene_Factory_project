using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChange : MonoBehaviour
{
    public Texture2D cursorTexture1;
    public Texture2D cursorTexture2;
    public bool hotSpotIsCenter = false;
    bool ClickCounter = true;
    public Vector2 adjustHotSpot = Vector2.zero;
    private Vector2 hotSpot;

    public void Start(){
        StartCoroutine("MyCursor");
    }

    public void Update(){
        if (Input.GetMouseButtonDown(0)){
            ClickCounter = false;
        }
        if (Input.GetMouseButtonUp(0)){
            ClickCounter = true;
        }
        if (ClickCounter == true)
            Cursor.SetCursor(cursorTexture1, hotSpot, CursorMode.Auto);
        else
            Cursor.SetCursor(cursorTexture2, hotSpot, CursorMode.Auto);
    }

    IEnumerator MyCursor(){
        yield return new WaitForEndOfFrame();

        if (hotSpotIsCenter){
            hotSpot.x = cursorTexture1.width / 2;
            hotSpot.y = cursorTexture1.height / 2;
        }
        else{
            hotSpot = adjustHotSpot;
        }

    }
}