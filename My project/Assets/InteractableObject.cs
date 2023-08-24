using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    
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

    public void ClickAndDrag()
    {
        if (isMouseOver)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Clicky!");
            }

            else if (Input.GetMouseButtonUp(0))
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

