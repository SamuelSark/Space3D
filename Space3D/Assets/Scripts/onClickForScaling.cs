using UnityEngine;
using System.Collections;

// Youtube Code Reference: https://www.youtube.com/watch?v=KoPI1-V07aw

public class onClickForScaling : MonoBehaviour {


 void OnMouseDown() {
  CSharpscaling.ScaleTransform = this.transform;
 }
}