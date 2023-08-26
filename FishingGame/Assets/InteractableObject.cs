using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    
    public  Vector3 mousePos;
    public  Vector3 worldPos;

    private bool isMouseOver = false;
    
    public int tensionValue = 0;

    private void OnMouseEnter()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

    public void  ClickAndDrag()
    {
        if (isMouseOver)
        {
            if (Input.GetMouseButton(0))
            {
                Debug.Log("Clicky!");
                mousePos = Input.mousePosition;
                mousePos.z = Camera.main.nearClipPlane + 19;

                worldPos = Camera.main.ScreenToWorldPoint(mousePos);

                transform.position = worldPos;
            }

            else 
            {
                Debug.Log("Unclicky!");
            }
        }
    }
   
 
    void Update()
    {
       ClickAndDrag();
    }
}

