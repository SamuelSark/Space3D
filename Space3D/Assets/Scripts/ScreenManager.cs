﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Video Code Reference https://www.youtube.com/watch?v=1rjzmYSIOhw&list=PLi7j3QUXwsNAD4ZNqm0M6ppSh0QOflvAC&index=4&t=614s

public class ScreenManager : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("WelcomeScreen");
    }
}
 