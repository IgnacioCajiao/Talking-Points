using UnityEngine;

public class CardCollector : MonoBehaviour
{
    public string cardName; 
    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            CollectCard();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    void CollectCard()
    {
        CardManager.Instance.AddCard(cardName);
        Debug.Log("Collected: " + cardName);

        FindObjectOfType<SceneTrigger>()?.OnCardCollected();

        Invoke(nameof(DisableCollider), 0.5f);
    }

    void DisableCollider()
    {
        GetComponent<Collider2D>().enabled = false; 
    }
}