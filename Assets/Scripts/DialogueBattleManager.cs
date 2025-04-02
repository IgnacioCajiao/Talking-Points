using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogueBattleManager : MonoBehaviour
{
    public TMP_Text promptText; 
    public TMP_Text responseText; 
    public GameObject cardSelectionPanel; 
    public GameObject continueButton; 

    public List<DialoguePromptSO> prompts; 
    private int currentPromptIndex = 0;

    void Start()
    {
        ShowNextPrompt();
    }

    void ShowNextPrompt()
    {
        if (currentPromptIndex < prompts.Count)
        {
            DialoguePromptSO prompt = prompts[currentPromptIndex];

            promptText.text = prompt.PromptDialogue;
            promptText.gameObject.SetActive(true);

            responseText.text = "";
            responseText.gameObject.SetActive(false);

            foreach (Button card in cardSelectionPanel.GetComponentsInChildren<Button>())
            {
                card.interactable = true; 
            }

            continueButton.SetActive(false);
        }
        else
        {
            EndBattle();
        }
    }

    public void OnCardSelected(string cardName)
    {
        DialoguePromptSO prompt = prompts[currentPromptIndex];

        promptText.gameObject.SetActive(false);

        responseText.text = (cardName == prompt.correctCardName) ? prompt.correctCardSelected : prompt.incorrectCardSelected;
        responseText.gameObject.SetActive(true);

        foreach (Button card in cardSelectionPanel.GetComponentsInChildren<Button>())
        {
            card.interactable = false; 
        }

        continueButton.SetActive(true); 
    }

    public void OnContinueButtonClicked()
    {
        currentPromptIndex++; 
        ShowNextPrompt(); 
    }

    void EndBattle()
    {
        promptText.text = "You've successfully countered all arguments!";
        responseText.text = "";
        cardSelectionPanel.SetActive(false); 
        continueButton.SetActive(false); 
    }
}