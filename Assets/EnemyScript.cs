using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float distanceFromPlayer;
    public float moveSpeed;
    public float explosionRadius;

    Transform player;

    void OnEnable(){
        player = FindObjectOfType<SpaceShipController>().transform;
        moveSpeed = 10f;
        explosionRadius = 1.2f;
    }

    void Update(){
        distanceFromPlayer = Vector3.Distance(transform.position, player.position);
        transform.position = Vector3.Lerp(transform.position, player.position, distanceFromPlayer / moveSpeed * Time.deltaTime);
        Explode();
    }

    void Explode()
    {
        if(distanceFromPlayer <= explosionRadius){
            //Explode
            Destroy(gameObject);
        }
    }
    void OnDrawGizmos(){
       Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }

   void OnDisable(){
        GameManager.current.enemiesSpawned.Remove(gameObject);
        Destroy(gameObject);
   }
}
