using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public int id;
    public void Start(){
        GameEvents.instance.OnDoorOpen += OpenDoor;
    }

    void OpenDoor(int id){
        if(id == this.id){
            Debug.Log(gameObject);
            transform.Translate(0,3,0);
            GameEvents.instance.OnDoorOpen -= OpenDoor;
        }
    }

}
