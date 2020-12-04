﻿using UnityEngine;
using System.Collections;

// Youtube Code Reference: https://www.youtube.com/watch?v=KoPI1-V07aw

public class CSharpscaling : MonoBehaviour {
 
 public float initialFingersDistance;
 public Vector3 initialScale;
 public static Transform ScaleTransform;
 
 
 void  Update (){
  int fingersOnScreen = 0;
  
  foreach(Touch touch in Input.touches) {
    //Count the # of fingers on screen
   fingersOnScreen++; 
   
   //Two fingers on screen are required to pinch.
   if(fingersOnScreen == 2){
    
    //First set the initial distance between fingers, so you can compare based on user input.
    if(touch.phase == TouchPhase.Began){
     initialFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
     initialScale = ScaleTransform.localScale;
    }
    else{
     float currentFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
     
     float scaleFactor = currentFingersDistance / initialFingersDistance;
     
     ScaleTransform.localScale = initialScale * scaleFactor; 
    }
   }
  }
 }
}
