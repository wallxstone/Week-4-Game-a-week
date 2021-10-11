using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
   Rigidbody2D rigidBody2D;
   public float velocity = 2f;


   void OnEnable(){
       rigidBody2D = GetComponent<Rigidbody2D>();

   } 
    void Update(){
       rigidBody2D.velocity = Vector2.up * velocity ;
    }
   void OnCollisionEnter2D(Collision2D other){
       other.gameObject.SetActive(false);
       gameObject.SetActive(false);
    }
}
