using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public CardManager cardManager;
    public GameObject[] cardSlots;


    private void Start()
    {
        DisplayCards();
    }
    private void DisplayCards()
    {
        for (int i = 0; i < cardManager.cards.Count; i++)
        {
            cardSlots[i].transform.GetChild[0].GetComponent.<Image>.
        }
    }


}
