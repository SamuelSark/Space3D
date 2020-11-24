using UnityEngine;
using System.Collections;

public class changeMaterial : MonoBehaviour {
 
     public Color redcolor;
     public Color bluecolor;
 
 
     void OnTriggerEnter(Collider other) {
 
         if (other.gameObject.CompareTag ("sphere")) 
         {
             Debug.Log ("It's ALIVE and red");
             transform.GetComponent<Renderer>().material.color= redcolor;
         }
 
         if (other.gameObject.CompareTag ("square")) 
         {
             Debug.Log ("It's ALIVE and blue");
             transform.GetComponent<Renderer>().material.color= bluecolor;
         }
     }
 }