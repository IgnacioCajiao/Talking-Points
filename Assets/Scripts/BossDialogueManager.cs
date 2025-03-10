using UnityEngine;
using TMPro;

public class BossDialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;  
    public string[] talkingPoints;       
    private int currentTalkingPoint = 0; 
    private int cardsPlayed = 0;         

    public void StartDialogue()
    {
        currentTalkingPoint = 0;
        cardsPlayed = 0; 
        ShowTalkingPoint();
    }

    public void ShowTalkingPoint()
    {
        if (currentTalkingPoint < talkingPoints.Length)
        {
            dialogueText.text = talkingPoints[currentTalkingPoint];
        }
    }

    public void NextTalkingPoint()
    {
        currentTalkingPoint++;
        if (currentTalkingPoint < talkingPoints.Length)
        {
            ShowTalkingPoint();
        }
    }

    public void CardPlayed()
    {
        cardsPlayed++;
        if (cardsPlayed == 3)
        {
            EndDialogue();
        }
    }

    public void UpdateDialogue(string newDialogue) 
    { 
        dialogueText.text = newDialogue; 
    }

    private void EndDialogue()
    {
        dialogueText.text = "You know what you had some really good points! You convinced me!"; 
    }
}
