using UnityEngine;

public class CodexDisplay : MonoBehaviour
{
    public GameObject[] allCards; // Array of all card objects in Codex Panel

    public void DisplayCards()
    {
        foreach (GameObject card in allCards)
        {
            if (CardManager.Instance.collectedCardNames.Contains(card.name))
            {
                card.SetActive(true); // Enable only collected cards
            }
            else
            {
                card.SetActive(false); // Keep others hidden
            }
        }
    }
}