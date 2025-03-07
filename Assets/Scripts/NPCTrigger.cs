using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    public GameObject talkButton; 
    public GameObject dialoguePanel; 
    private bool playerInRange = false; 

    void Start()
    {
        if (talkButton != null)
        {
            talkButton.SetActive(false); 
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            playerInRange = true;
            if (talkButton != null)
            {
                talkButton.SetActive(true); 
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            playerInRange = false;
            if (talkButton != null)
            {
                talkButton.SetActive(false);
            }

            if (dialoguePanel != null)
            {
                dialoguePanel.SetActive(false); 
            }
        }
    }

    public void ShowDialogue()
    {
        if (playerInRange && dialoguePanel != null)
        {
            dialoguePanel.SetActive(true); 
        }
    }
}
