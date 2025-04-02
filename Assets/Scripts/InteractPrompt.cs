using UnityEngine;

public class InteractPrompt : MonoBehaviour
{
    public GameObject interactText; // UI Text that says "Press E to Interact"
    public GameObject imagePanel;  // Panel that will display the image
    private bool playerInRange = false;

    void Start()
    {
        if (interactText != null)
        {
            interactText.SetActive(false); // Hide prompt initially
        }

        if (imagePanel != null)
        {
            imagePanel.SetActive(false); // Hide image panel initially
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
                interactText.SetActive(true); // Show "Press E to Interact"
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
                interactText.SetActive(false); // Hide text when player leaves
            }

            if (imagePanel != null)
            {
                imagePanel.SetActive(false); // Hide image panel when player leaves
            }
        }
    }

    void ToggleImagePanel()
    {
        if (imagePanel != null)
        {
            imagePanel.SetActive(!imagePanel.activeSelf); // Toggle visibility
        }
    }
}