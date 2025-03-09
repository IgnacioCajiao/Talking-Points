using UnityEngine;
using TMPro;

public class BossDialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText; // Boss dialogue UI
    public string[] talkingPoints;      // List of boss talking points
    private int currentTalkingPoint = 0;

    public void StartDialogue()
    {
        currentTalkingPoint = 0;
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
        else
        {
            EndDialogue();
        }
    }

    private void EndDialogue()
    {
        dialogueText.text = "You big brained me!"; 
    }

    public string GetCurrentTalkingPoint()
    {
        return currentTalkingPoint < talkingPoints.Length ? talkingPoints[currentTalkingPoint] : null;
    }

    public void UpdateDialogue(string newDialogue)
    {
        dialogueText.text = newDialogue; 
    }

}
