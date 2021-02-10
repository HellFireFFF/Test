using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Run()
    {
        SceneManager.LoadScene("The Crossing");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void     MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }

}
