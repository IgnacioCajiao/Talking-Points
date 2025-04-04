using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public void QuitButton()
    {
        SceneManager.LoadScene("ParkLevel");
    }

    public void NextButtonToLevel()
    {
        SceneManager.LoadScene("ParkLevel");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("TitleInstructions");
    }

    public void NextButtonToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void NextButtonToBattle()
    {
        SceneManager.LoadScene("ParkBattle");
    }
}