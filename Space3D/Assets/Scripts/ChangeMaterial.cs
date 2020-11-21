using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(Collider))]


public class ChangeMaterial : MonoBehaviour
{
    public Material[] mats;
    //Renderer rend;

    public Material CorrectMat;
    public Material WrongMat;
    private MeshRenderer m_meshRenderer;

    public string AnswerBoxTag = "AnswerBox";
    public string ElectronTag = "Electron";
    public string LightTag = "Light";

    private void Start()
    {
        m_meshRenderer = GetComponent<MeshRenderer>();
        
    }

    // Update is called once per frame
    private void OnCollisionEnter (Collision other)
    {
        /*
        if (other.gameObject.CompareTag(ElectronTag)){
            m_meshRenderer.material = CorrectMat;
        }
        else if (other.gameObject.CompareTag(LightTag)){
            m_meshRenderer.material = WrongMat;
        }
        */

        if (other.transform.tag == "Electron"){
            m_meshRenderer.material = CorrectMat;
        }
        else if (other.transform.tag == "Light"){
            m_meshRenderer.material = WrongMat;
        }
    }
}
