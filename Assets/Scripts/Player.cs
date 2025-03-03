using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasGreenKey = false;
    public bool hasBlueKey = false;
    public bool hasRedKey = false;

    public GameObject PlayerCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //if player presses E
        {
            RaycastHit hit; //declares raycast variable

            if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit, 10f))
            {
                if (hit.collider.tag == "Door") // if raycast hits collider of objects tagged "door"
                {
                    LockedDoor door = hit.collider.gameObject.GetComponent<LockedDoor>();
                    
                    if (door.isDoorLocked == true)
                    {
                        //Open The Door
                    }
                    else 
                    {
                        if ((door.keyColorRequired == KeyColor.Green && hasGreenKey) ||
                            (door.keyColorRequired == KeyColor.Blue && hasGreenKey) ||
                            (door.keyColorRequired == KeyColor.Red && hasRedKey))
                        {
                            //Open The Door
                        }
                    }
                    
                }
            }
        }
    }
}
