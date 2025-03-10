using UnityEngine;

public class Card : MonoBehaviour
{
    public BossDialogueManager bossDialogueManager; 
    public string wrongCardDialogue;               
    public Sprite cardSpecificSprite;               
    public SpriteRenderer targetSpriteRenderer;     

    // Handles correct card logic
    public void CorrectCard()
    {
        if (bossDialogueManager != null)
        {
            bossDialogueManager.NextTalkingPoint();  
            bossDialogueManager.CardPlayed();        
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
        }
        else
        {
            Debug.LogError("BossDialogueManager is not assigned!");
        }
    }

    public void OnCardClick()
    {
        if (targetSpriteRenderer != null)
        {
            targetSpriteRenderer.sprite = cardSpecificSprite; 
        }
        else
        {
            Debug.LogError("Target SpriteRenderer is not assigned!");
        }
    }
}
