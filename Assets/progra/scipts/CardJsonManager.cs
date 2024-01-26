using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CardJsonManager : MonoBehaviour
{
    public GameObject cartaPrefab;
    public Transform contenedorCartas;

    void Start()
    {
       
        string jsonPath = "Assets/progra/Resources/jsonfile.txt"; 
        TextAsset jsonFile = Resources.Load<TextAsset>(jsonPath);

        // Analizar el JSON
        CartaList cartasData = JsonUtility.FromJson<CartaList>(jsonFile.text);

        // Mostrar las cartas en la escena
        foreach (var cartaData in cartasData.carta)
        {
            // Instanciar una nueva carta desde el prefab
            GameObject nuevaCarta = Instantiate(cartaPrefab, contenedorCartas);

            // Obtener el componente CardUI para establecer los datos
            CardUI cartaUI = nuevaCarta.GetComponent<CardUI>();
            cartaUI.SetCardInfo(cartaData);
        }
    }
}


