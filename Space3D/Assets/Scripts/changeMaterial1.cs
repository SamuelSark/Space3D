using UnityEngine;
 using System.Collections;
 
 // Code Ref: https://answers.unity.com/questions/1255990/how-to-change-the-color-of-an-object-when-it-colli.html

 public class changeMaterial1 : MonoBehaviour {
 
     public Color correctColor;
     public Color wrongColor;
 
 
     void OnTriggerEnter(Collider other) {
 
         if (other.gameObject.CompareTag ("Electron")) 
         {
             Debug.Log ("correct");
             transform.GetComponent<Renderer>().material.color= correctColor;
         }
 
         if (other.gameObject.CompareTag ("Light")) 
         {
             Debug.Log ("wrong");
             transform.GetComponent<Renderer>().material.color= wrongColor;
         }
     }
 }
