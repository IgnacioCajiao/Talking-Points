using UnityEngine;

public class Card : MonoBehaviour
{
    public BossDialogueManager bossDialogueManager;
    public string wrongCardDialogue;
    public GameObject cardPreviewPanel;

    public void CorrectCard()
    {
        if (bossDialogueManager != null)
        {
            bossDialogueManager.NextTalkingPoint();
            bossDialogueManager.CardPlayed();
            DisableCardPreview(); 
        }
        else
        {
            Debug.LogError("BossDialogueManager is not assigned!");
        }
    }

    public void WrongCard()
    {
        if (bossDialogueManager != null)
        {
            bossDialogueManager.UpdateDialogue(wrongCardDialogue);
            bossDialogueManager.CardPlayed();
            DisableCardPreview(); 
        }
        else
        {
            Debug.LogError("BossDialogueManager is not assigned!");
        }
    }

    public void OnCardClick()
    {
        DisableCardPreview(); 
    }

    private void DisableCardPreview()
    {
        if (cardPreviewPanel != null)
        {
            cardPreviewPanel.SetActive(false); 
        }
        else
        {
            Debug.LogError("CardPreviewPanel is not assigned!");
        }
    }
}
