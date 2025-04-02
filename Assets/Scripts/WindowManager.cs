using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public List<GameObject> windows; 

    public void ShowWindow(GameObject windowToShow)
    {
        foreach (GameObject window in windows)
        {
            if (window != null)
            {
                window.SetActive(window == windowToShow); 
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
