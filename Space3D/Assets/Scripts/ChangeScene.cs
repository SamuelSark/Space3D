using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public Button continueButton;

    // Start is called before the first frame update
    void Start()
    {
        continueButton.onClick.AddListener(changeScene);
    }

    // Update is called once per frame
    void changeScene()
    {
        SceneManager.LoadScene("Login");
    }
}
