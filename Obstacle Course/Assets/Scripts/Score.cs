using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int _hits = 0;
   
   private void OnCollisionEnter(Collision other)
   {
       if(other.gameObject.tag != "Hit")
       {
           _hits++;
       }
   }
}
