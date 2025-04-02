using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public List<GameObject> windows; // List of all UI windows

    public void ShowWindow(GameObject windowToShow)
    {
        foreach (GameObject window in windows)
        {
            if (window != null)
            {
                window.SetActive(window == windowToShow);
            }
        }

        // If Codex Panel is opened, refresh its displayed cards
        if (windowToShow.CompareTag("CodexPanel")) // Make sure your Codex UI has this tag
        {
            CodexDisplay codexDisplay = windowToShow.GetComponent<CodexDisplay>();
            if (codexDisplay != null)
            {
                codexDisplay.DisplayCards(); // Refresh the Codex cards
            }
        }
    }

    public void CloseAllWindows()
    {
        foreach (GameObject window in windows)
        {
            if (window != null)
            {
                window.SetActive(false);
            }
        }
    }
}