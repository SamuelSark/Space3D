using UnityEngine;
using System.Collections;

// Youtube Code Reference: https://www.youtube.com/watch?v=KoPI1-V07aw

public class Rotate : MonoBehaviour {
 
 // Update is called once per frame
 void Update () {
  transform.Rotate(0,20*Time.deltaTime,0);
 }
}