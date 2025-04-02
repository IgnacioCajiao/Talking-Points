using UnityEngine;

[CreateAssetMenu(fileName = "NewDialoguePrompt", menuName = "Dialogue Battle/Dialogue Prompt")]
public class DialoguePromptSO : ScriptableObject
{
    public string PromptDialogue; 
    public string correctCardName; 
    public string correctCardSelected; 
    public string incorrectCardSelected; 
}