using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
   float shootDelay;
   public bool canShoot;
   
   public GameObject bullet;
    void OnEnable(){
        shootDelay = 2f;
    }
    void Update(){
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, Mathf.Infinity);
        if(hit.collider.gameObject.CompareTag("Enemy")) canShoot = false;
        else {
            canShoot = true;
        }
        StartCoroutine(Shoot());     
    }

    private void OnDrawGizmos() {
        Debug.DrawRay(transform.position, Vector2.down);
    }
    IEnumerator Shoot(){
       if(canShoot == true){
        yield return new WaitForSeconds(shootDelay);
        Debug.Log("Enemy has shot!");
        Instantiate(bullet, transform.position,transform.rotation);
       } else {
           Debug.Log("Can't shoot blocked by friend");
       }
       
    }
}
