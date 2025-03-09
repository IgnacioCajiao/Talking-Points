using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public BossDialogueManager bossDialogueManager; // Handles boss dialogue

    void Start() // Automatically called when the scene starts
    {
        StartBattle(); // Call the battle logic here
    }

    private void StartBattle()
    {
        Debug.Log("Battle is starting!");
        bossDialogueManager.StartDialogue(); // Start the boss dialogue flow
    }
}
