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
        
        StartCoroutine(Shoot());     
    }

    private void OnDrawGizmos() {
        Debug.DrawRay(transform.position, Vector2.down);
    }
    IEnumerator Shoot(){
        yield return new WaitForSeconds(shootDelay);
        Debug.Log("Enemy has shot!");
        Instantiate(bullet, transform.position,transform.rotation);
    }
}
