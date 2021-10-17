using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
   public float health;
   public float damage;

   void OnEnable(){
       GameManager.current.enemiesSpawned.Add(gameObject);
       health = 100f;
       damage = 10f;
   }
   void AttackPlayer()
   {
       //Some type of damage/attack, maybe spawn bullets in different directions!?
   }
   public void TakeDamage(float damage){
       health -= damage;
       if(health <= 0)
       {
           //Some effect
           Destroy(gameObject);
       }
   }
   void OnDestroy(){
       GameManager.current.enemiesSpawned.Remove(gameObject);
   }
}
