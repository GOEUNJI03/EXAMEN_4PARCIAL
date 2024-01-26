using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    [SerializeField] private TMP_Text nameText;
    [SerializeField] private TMP_Text descriptionText;
    [SerializeField] private TMP_Text classText;
    [SerializeField] private TMP_Text atkText;
    [SerializeField] private TMP_Text defText;
    [SerializeField] private Image playerImage;

    public void SetCardInfo(CardJson card)
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        classText.text = card.Class;
        atkText.text = card.atk.ToString();
        defText.text = card.def.ToString();
        playerImage.sprite = LoadImageFromPath(card.playerImage);
    }

    private Sprite LoadImageFromPath(string path)
    {
        string fullPath = path;  // No es necesario agregar "imagenes/" aquí
        Debug.Log("Intentando cargar la imagen desde la ruta: " + fullPath);

        // Cargar la imagen desde Resources usando Load
        Sprite sprite = Resources.Load<Sprite>(fullPath);

        if (sprite == null)
        {
            Debug.LogError("No se pudo cargar la imagen desde la ruta: " + fullPath);
        }

        return sprite;
    }





}
