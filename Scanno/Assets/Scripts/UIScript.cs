using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LaunchGame()
    {
        SceneManager.LoadScene(1);
    }
}
