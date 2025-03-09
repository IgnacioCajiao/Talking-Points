using UnityEngine;

public class Card : MonoBehaviour
{
    public BossDialogueManager bossDialogueManager; 
    public string wrongCardDialogue; 

    public void CorrectCard()
    {
        if (bossDialogueManager != null)
        {
            bossDialogueManager.NextTalkingPoint();
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
        }
        else
        {
            Debug.LogError("BossDialogueManager is not assigned!");
        }
    }
}
