using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("Scene1_wakeUp");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
