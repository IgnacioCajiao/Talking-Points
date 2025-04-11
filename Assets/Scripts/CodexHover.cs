using UnityEngine;
using UnityEngine.UI;

public class CardHover : MonoBehaviour
{
    public GameObject hoverCardPanel;
    public Image hoverCardImage;
    public Image cardImage;

    void Start()
    {
        cardImage.color = new Color(1, 1, 1, 0);
    }

    public void OnCardHover(Sprite largeCardSprite)
    {
        hoverCardImage.sprite = largeCardSprite;
        hoverCardImage.color = new Color(1, 1, 1, 1);
        hoverCardPanel.SetActive(true);
    }

    public void OnCardExit()
    {
        hoverCardPanel.SetActive(false);
    }
}