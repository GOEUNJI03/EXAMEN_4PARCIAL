using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New card", menuName = "Card")]

    public class Card : ScriptableObject
{
    public string Name;
    public Sprite image;
    public string description;
    public int atk;
    public int def;
    public string type;

}

[System.Serializable]

public class CardList
{
    public Card[] card;

}