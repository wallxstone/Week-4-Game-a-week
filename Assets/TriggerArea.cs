using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;
    void Start(){
        id = GetComponent<DoorController>().id;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        GameEvents.instance.DoorOpened(id);
    }
}
