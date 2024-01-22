using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    [SerializeField] private TextAsset jsonfile;
    public CartaList cardlist = new CartaList();

    void Start()
    {
        cardlist = JsonUtility.FromJson<CartaList>(jsonfile.text);
    }


}

