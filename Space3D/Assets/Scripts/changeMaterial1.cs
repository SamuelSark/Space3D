using UnityEngine;
using System.Collections;
using System.IO;
 
 // Code Ref: https://answers.unity.com/questions/1255990/how-to-change-the-color-of-an-object-when-it-colli.html

 public class changeMaterial1 : MonoBehaviour {
 
     public Color correctColor;
     public Color wrongColor;
 
 
     int progressCorrect;
     int progressIncorrect;
        void OnTriggerEnter(Collider other) {
 


         if (other.gameObject.CompareTag ("Electron")) 
         {
             Debug.Log ("correct");
             transform.GetComponent<Renderer>().material.color= correctColor;
             progressCorrect = 1;
             progressIncorrect = 0;
             Debug.Log(progressCorrect);

             File.WriteAllText(Application.dataPath + "/userProgressData.txt", ("Correct = " + progressCorrect)
                         + "\t Incorrect = " + progressIncorrect);
         }
 
         if (other.gameObject.CompareTag ("Light")) 
         {
             Debug.Log ("wrong");
             transform.GetComponent<Renderer>().material.color= wrongColor;
             progressIncorrect = 1;
             progressCorrect = 0;
             Debug.Log(progressIncorrect);
             File.WriteAllText(Application.dataPath + "/userProgressData.txt", ("Incorrect = " + progressIncorrect 
                        + "\t Correct = " + progressCorrect));
         }
     }

 }
