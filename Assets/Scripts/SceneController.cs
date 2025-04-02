using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void QuitButton()
    {
        SceneManager.LoadScene("ParkLevel");
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("ParkLevel");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}