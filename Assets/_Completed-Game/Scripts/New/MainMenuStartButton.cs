﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuStartButton : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("GamePlayInstructins"); 
    }
}
