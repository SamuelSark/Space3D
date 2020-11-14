using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class UI : MonoBehaviour
{
    [SerializeField]
    private GameObject welcomePanel;

    [SerializeField]
    private Button dismissButton;

    void Awake(){
        dismissButton.onClick.AddListener(Dismiss);
    }

    private void Dismiss() => welcomePanel.SetActive(false);

}
