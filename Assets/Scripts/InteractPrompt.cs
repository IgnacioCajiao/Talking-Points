using UnityEngine;

public class InteractPrompt : MonoBehaviour
{
    public GameObject interactText; 
    public GameObject imagePanel;  
    private bool playerInRange = false;

    void Start()
    {
        if (interactText != null)
        {
            interactText.SetActive(false); 
        }

        if (imagePanel != null)
        {
            imagePanel.SetActive(false); 
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            ToggleImagePanel();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            if (interactText != null)
            {
                interactText.SetActive(true); 
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            if (interactText != null)
            {
                interactText.SetActive(false); 
            }

            if (imagePanel != null)
            {
                imagePanel.SetActive(false); 
            }
        }
    }

    void ToggleImagePanel()
    {
        if (imagePanel != null)
        {
            imagePanel.SetActive(!imagePanel.activeSelf); 
        }
    }
}