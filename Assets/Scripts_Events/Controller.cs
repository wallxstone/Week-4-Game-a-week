using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
   void Update(){
       float x = Input.GetAxisRaw("Horizontal");
       float y = Input.GetAxisRaw("Vertical");

       
       transform.Translate(x * Time.deltaTime,y  * Time.deltaTime,0);
   }
}
