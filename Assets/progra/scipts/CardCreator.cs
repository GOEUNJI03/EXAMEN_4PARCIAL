using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using TMPro;

public class CardCreator : MonoBehaviour
{
    public TMP_InputField Name;
    public TMP_InputField Class;
    public TMP_InputField Description;
    public TMP_InputField Atk;
    public TMP_InputField Def;
    public Text feedbackText;
    public GameObject cardPrefab;
    public Transform cardListParent;

    private void Start()
    {
        // Puedes agregar código de inicialización aquí
    }

    public void SaveCard()
    {
        string cardName = Name.text;
        string cardClass = Class.text;
        string cardDescription = Description.text;
        string cardAtk = Atk.text;
        string cardDef = Def.text;

        string imagePath = PlayerPrefs.GetString("SavedCardImagePath", "");

        if (!string.IsNullOrEmpty(cardName) && !string.IsNullOrEmpty(imagePath))
        {
            int atk = int.TryParse(cardAtk, out int atkValue) ? atkValue : 0;
            int def = int.TryParse(cardDef, out int defValue) ? defValue : 0;

            Cardprefab cardPrefabInstance = Instantiate(cardPrefab, cardListParent).GetComponent<Cardprefab>();

            // Asegúrate de tener el sprite correcto antes de llamar a SetCardData
            Sprite cardSprite = LoadSprite(imagePath);

            // Llama al método SetCardData para establecer los datos de la carta en el prefab
            cardPrefabInstance.SetCardData(cardName, cardDescription, atk, def, cardSprite, cardClass);

            SaveCardKey();
            feedbackText.text = "Carta guardada exitosamente.";
        }
        else
        {
            feedbackText.text = "El contenido de la carta o la imagen está vacío. No se puede guardar.";
        }
    }

    private Sprite LoadSprite(string imagePath)
    {
        byte[] imageData = File.ReadAllBytes(imagePath);
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(imageData);

        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
    }

    public void SelectImage()
    {
#if UNITY_EDITOR
        string defaultPath = "Assets/arte/imagenes";
        string imagePath = UnityEditor.EditorUtility.OpenFilePanel("Seleccione una imagen", defaultPath, "png,jpg,jpeg");

        if (!string.IsNullOrEmpty(imagePath) && imagePath.StartsWith(Application.dataPath))
        {
            imagePath = "Assets" + imagePath.Substring(Application.dataPath.Length);
            PlayerPrefs.SetString("SavedCardImagePath", imagePath);
            LoadImage(imagePath);
        }
#endif
    }

    public void ShowSavedCards()
    {
        // Borra las cartas antiguas antes de mostrar las nuevas
        foreach (Transform child in cardListParent)
        {
            Destroy(child.gameObject);
        }

        // Itera a través de todas las claves de PlayerPrefs
        string[] allKeys = PlayerPrefs.GetString("SavedCardsKeys", "").Split(';');
        foreach (string key in allKeys)
        {
            if (!string.IsNullOrEmpty(key))
            {
                string savedCardContent = PlayerPrefs.GetString(key + "_Content", "");
                string savedImagePath = PlayerPrefs.GetString(key + "_ImagePath", "");

                // Instancia el Prefab de la carta
                Cardprefab cardPrefabInstance = Instantiate(cardPrefab, cardListParent).GetComponent<Cardprefab>();

                // Asegúrate de tener el sprite correcto antes de llamar a SetCardData
                Sprite cardSprite = LoadSprite(savedImagePath);

                // Llama al método SetCardData para establecer los datos de la carta en el prefab
                cardPrefabInstance.SetCardData(savedCardContent, "", 0, 0, cardSprite, "");

                // Puedes ajustar esto según tus necesidades
            }
        }

        feedbackText.text = "Cartas mostradas exitosamente.";
    }

    private void LoadImage(string imagePath)
    {
        byte[] imageData;

#if UNITY_EDITOR
        // En el Editor de Unity, utiliza la ruta directa al archivo
        imageData = File.ReadAllBytes(imagePath);
#else
    // En tiempo de ejecución, utiliza la ruta directa al archivo
    imageData = File.ReadAllBytes(imagePath);
#endif

        Texture2D loadedTexture = new Texture2D(2, 2);
        loadedTexture.LoadImage(imageData);

        Image cardImage = cardPrefab.GetComponentInChildren<Image>();
        if (cardImage != null)
        {
            cardImage.sprite = Sprite.Create(loadedTexture, new Rect(0, 0, loadedTexture.width, loadedTexture.height), new Vector2(0.5f, 0.5f));
        }
    }

    private void SaveCardKey()
    {
        string savedCardKeys = PlayerPrefs.GetString("SavedCardsKeys", "");
        string currentCardKey = System.DateTime.Now.ToString("yyyyMMddHHmmss");
        PlayerPrefs.SetString("SavedCardsKeys", savedCardKeys + currentCardKey + ";");
    }
}

