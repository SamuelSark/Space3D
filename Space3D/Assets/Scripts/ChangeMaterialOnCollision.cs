using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Collider))]

public class ChangeMaterialOnCollision : MonoBehaviour
{
    //[SerializeField] dont need for public vars
    public Material correctMat;
    public Material incorrectMat;
    private MeshRenderer m_meshRenderer;

    private void Start()
    {
        m_meshRenderer = GetComponent<MeshRenderer>();
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Electron")
        {
            m_meshRenderer.material = correctMat;
        }
        else
        {
            m_meshRenderer.material = incorrectMat;
        }
    }

}
