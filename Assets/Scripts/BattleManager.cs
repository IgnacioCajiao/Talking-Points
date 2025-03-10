using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public BossDialogueManager bossDialogueManager; 

    void Start() 
    {
        StartBattle(); 
    }

    private void StartBattle()
    {
        Debug.Log("Battle is starting!");
        bossDialogueManager.StartDialogue(); 
    }
}
