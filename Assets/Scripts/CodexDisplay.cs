using UnityEngine;

public class CodexDisplay : MonoBehaviour
{
    public GameObject[] allCards; 

    public void DisplayCards()
    {
        foreach (GameObject card in allCards)
        {
            if (CardManager.Instance.collectedCardNames.Contains(card.name))
            {
                card.SetActive(true); 
            }
            else
            {
                card.SetActive(false); 
            }
        }
    }
}