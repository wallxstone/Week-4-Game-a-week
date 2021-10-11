using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public GameObject bullet;
    void Update(){
        
        if(Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
    }
    public void Shoot(){
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
