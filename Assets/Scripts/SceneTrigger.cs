using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public GameObject BattleButton;
    public TMP_Text buttonText;
    public string sceneToLoad;

    private bool playerInRange = false;
    private bool canTalk = false;
    private static int collectedCards = 0; 

    void Awake()
    {
        DontDestroyOnLoad(gameObject); 
    }

    void Start()
    {
        if (BattleButton != null)
        {
            BattleButton.SetActive(false);
        }

        UpdateButtonText();
    }

    void Update()
    {
        if (playerInRange && canTalk && Input.GetKeyDown(KeyCode.E))
        {
            LoadScene();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;

            if (BattleButton != null)
            {
                BattleButton.SetActive(true);
            }

            UpdateButtonText();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;

            if (BattleButton != null)
            {
                BattleButton.SetActive(false);
            }
        }
    }

    public void OnCardCollected()
    {
        collectedCards++;
        UpdateButtonText();
    }

    void UpdateButtonText()
    {
        if (buttonText != null)
        {
            if (collectedCards >= 9)
            {
                buttonText.text = "TALK?";
                canTalk = true;
            }
            else
            {
                buttonText.text = "Cards collected " + collectedCards + "/9";
            }
        }
    }

    public void LoadScene()
    {
        if (playerInRange && canTalk && !string.IsNullOrEmpty("BattleInstructions"))
        {
            SceneManager.LoadScene("BattleInstructions");
        }
    }
}