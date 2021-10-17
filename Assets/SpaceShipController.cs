using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    float x;
    float y;
    float moveSpeed = 100f;

    public Rigidbody2D rb;
    
    public void FixedUpdate(){
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(x * moveSpeed * Time.fixedDeltaTime,y * moveSpeed * Time.fixedDeltaTime);
        // transform.Translate(new Vector3(x * Time.deltaTime,0,0));
    }
}
