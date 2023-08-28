using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public int maxDistance = 3;
    public int currentDistance = 0;
    public Vector3 mousePos;
    public Vector3 worldPos;
    /*
     We need the garbage object to follow at a offset with a velocity
    We will accomplish this by: 
    give player a distance from garbage variable
    give player a current distance from garbage variable
    give garbage a speed variable 
    let player check distance from mouse to distance from garbage
    let player check garbage speed 
    if garbage distance from player >= max and garbage speed = maxSpeed
        pointMouseDirection
        cut the rope
    if garbage distance from player < maxDistance and garbage speed <= maxSpeed
        pointMouseDirection
    if garbage distance from player == maxDistance and garbage speed < maxSpeed
        pointMouseDirection
        increases speed to mouseSpeed
    if garbageDistancetoPlayer < maxDistance and ObjSpeed = maxSpeed
        point to mouseDireciton
        friction = mu * garbageWeight
        
        
        
    
    
    
     */

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

                if (maxDistance < 3)
                {

                }
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

