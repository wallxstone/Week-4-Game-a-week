using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    float x;

    public void Update(){
        x = Input.GetAxisRaw("Horizontal");

        transform.Translate(new Vector3(x * Time.deltaTime,0,0));
    }
}
