using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
   public delegate void PowerAction();
   public static event PowerAction power;
  
  
   public void PowerupTouch()
   {
       Debug.Log("hii");
       if (power != null)
       {
           power();
           Debug.Log("hi1");
       }
   }
}
