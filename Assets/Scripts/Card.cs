using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum CardColour
{
    Blue,
    Red,
    Green

}

public class Card
{
    public string cardName;
    [TextArea(1, 3)]
    public string cardDesc;

    public Sprite cardSprite;
    public Sprite cardBGSprite;

    public CardColour cardColour;




}
