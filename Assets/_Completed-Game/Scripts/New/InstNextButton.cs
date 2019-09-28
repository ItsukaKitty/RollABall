using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstNextButton : MonoBehaviour
{
    public void NextButton()
    {
        SceneManager.LoadScene("LVL1");
    }
}
