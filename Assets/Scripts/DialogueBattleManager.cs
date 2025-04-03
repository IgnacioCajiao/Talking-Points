using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DialogueBattleManager : MonoBehaviour
{
    public TMP_Text promptText;
    public TMP_Text responseText;
    public GameObject cardSelectionPanel;
    public GameObject continueButton;

    public SpriteRenderer enemySpriteRenderer;
    public Sprite neutralSprite;
    public Sprite correctResponseSprite;
    public Sprite incorrectResponseSprite;

    public GameObject hoverCardPanel;
    public Image hoverCardImage;

    public Slider infoSlider;
    public Slider misinfoSlider;

    private int correctSelections = 0;
    private int incorrectSelections = 0;

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

            enemySpriteRenderer.sprite = neutralSprite;

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

        if (cardName == prompt.correctCardName)
        {
            responseText.text = prompt.correctCardSelected;
            enemySpriteRenderer.sprite = correctResponseSprite;

            correctSelections++;
            infoSlider.value = (float)correctSelections / 9f;

            foreach (Button card in cardSelectionPanel.GetComponentsInChildren<Button>())
            {
                if (card.name == cardName)
                {
                    card.gameObject.SetActive(false);
                }
            }
        }
        else
        {
            responseText.text = prompt.incorrectCardSelected;
            enemySpriteRenderer.sprite = incorrectResponseSprite;

            incorrectSelections++;
            misinfoSlider.value = (float)incorrectSelections / 4f;

            if (incorrectSelections >= 4)
            {
                ShowLoseMessage();
                return;
            }
        }

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
        promptText.gameObject.SetActive(true);
        responseText.gameObject.SetActive(true);

        promptText.text = "You've successfully countered all arguments!";
        responseText.text = "";

        cardSelectionPanel.SetActive(false);
        continueButton.SetActive(false);

        enemySpriteRenderer.sprite = neutralSprite;
    }

    void ShowLoseMessage()
    {
        promptText.gameObject.SetActive(true);
        promptText.text = "Misinformation reached full! You lost!";

        responseText.gameObject.SetActive(false);
        cardSelectionPanel.SetActive(false);
        continueButton.SetActive(false);

        Invoke("RestartScene", 3f);
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnCardHover(Sprite largeCardSprite)
    {
        hoverCardImage.sprite = largeCardSprite;
        hoverCardPanel.SetActive(true);
    }

    public void OnCardExit()
    {
        hoverCardPanel.SetActive(false);
    }
}