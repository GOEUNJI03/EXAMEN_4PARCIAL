using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardJson 
{
    public string name;
    public string description;
    public string type;
    public float atk;
    public float def;
}
[System.Serializable]

public class CartaList
{
    public CardJson[] carta;
}