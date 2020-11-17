using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float moveSpeed;

    public void Update(){
        float v = Input.GetAxis ("Vertical") * moveSpeed;
        transform.Translate  (new Vector3(0, 0, v) * Time.deltaTime);
        /*GameObject sphere = (GameObject) Instantiate(spawnPrefab, transform.position, Quaternion.identity);
        sphere.transform.LookAt(Camera.main.transform);*/

    }
}
    
