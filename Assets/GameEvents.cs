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

   public event Action OnDoorOpen;

   public void DoorOpened()
   {
       if(OnDoorOpen != null)
       {
           OnDoorOpen();
       }
   }
}
