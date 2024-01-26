[System.Serializable]
public class CardJson
{
    public string name;
    public string playerImage;
    public string description;
    public string Class;
    public float atk;
    public float def;
}

[System.Serializable]
public class CartaList
{
    public CardJson[] carta;
}

