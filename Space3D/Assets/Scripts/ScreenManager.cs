using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Video Code Reference https://www.youtube.com/watch?v=1rjzmYSIOhw&list=PLi7j3QUXwsNAD4ZNqm0M6ppSh0QOflvAC&index=4&t=614s

public class ScreenManager : MonoBehaviour
{
	//loads the AR exercise 
    public void StartGame() {
        SceneManager.LoadScene("Space3DVuforia");
    }
    //loads the welcome screen
    public void WelcomeScreen() {
        SceneManager.LoadScene("WelcomeScreen");
    }
    //loads the instruction screen
    public void InstructionScreen() {
        SceneManager.LoadScene("InstructionScreen");
    }
}
 