using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    [SerializeField] private TextAsset jsonfile;
    public CartaList cardlist = new CartaList();
    public GameObject cartaPrefab;
    public Transform contenedorCartas;

    void Start()
    {
        cardlist = JsonUtility.FromJson<CartaList>(jsonfile.text);

        // Mostrar las cartas en la escena
        foreach (var cartaData in cardlist.carta)
        {
            // Instanciar una nueva carta desde el prefab
            GameObject nuevaCarta = Instantiate(cartaPrefab, contenedorCartas);

            // Obtener el componente CartaComponent para establecer los datos
            CardUI cartaUI = nuevaCarta.GetComponent<CardUI>();
            cartaUI.SetCardInfo(cartaData);
        }
    }
}

