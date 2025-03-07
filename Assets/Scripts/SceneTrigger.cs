using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneTrigger : MonoBehaviour
{
    public GameObject BattleButton; 
    public string sceneToLoad; 
    private bool playerInRange = false; 

    void Start()
    {
        if (BattleButton != null)
        {
            BattleButton.SetActive(false); 
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            playerInRange = true;
            if (BattleButton != null)
            {
                BattleButton.SetActive(true); 
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            playerInRange = false;
            if (BattleButton != null)
            {
                BattleButton.SetActive(false); 
            }
        }
    }

    public void LoadScene()
    {
        if (playerInRange && !string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad); // Load the specified scene
        }
    }
}
