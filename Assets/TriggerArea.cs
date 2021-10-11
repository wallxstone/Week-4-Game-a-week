using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GameEvents.instance.DoorOpened();
    }
}
