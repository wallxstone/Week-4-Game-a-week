using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents instance;

   void Awake(){
       instance = this;
   }

   public event Action<int> OnDoorOpen;

   public void DoorOpened(int id)
   {
       if(OnDoorOpen != null)
       {
           OnDoorOpen(id);
       }
   }
}
