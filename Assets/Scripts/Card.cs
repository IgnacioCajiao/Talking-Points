using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu]

//public enum CardColour
//{
  //  Blue,
 //   Red,
 //   Green

//}

public class Card : ScriptableObject
{
     public string cardName;
    [TextArea(1, 3)]
     public string cardDesc;

     public Sprite cardSprite;
     public Sprite cardBGSprite;

    // public CardColour cardColour;




}
