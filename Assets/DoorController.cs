using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public void Start(){
        GameEvents.instance.OnDoorOpen += OpenDoor;
    }

    void OpenDoor(){
        Debug.Log(gameObject);
        transform.Translate(0,3,0);
        GameEvents.instance.OnDoorOpen -= OpenDoor;
    }

}
