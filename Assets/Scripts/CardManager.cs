using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager Instance;
    public List<string> collectedCardNames = new List<string>(); // Store card names

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCard(string cardName)
    {
        if (!collectedCardNames.Contains(cardName)) // Prevent duplicates
        {
            collectedCardNames.Add(cardName);
        }
    }
}