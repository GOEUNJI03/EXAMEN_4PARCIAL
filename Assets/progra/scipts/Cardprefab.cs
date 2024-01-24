using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Cardprefab : MonoBehaviour
{
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text description;
    [SerializeField] private Image art;
    [SerializeField] private TMP_Text atk;
    [SerializeField] private TMP_Text def;
    [SerializeField] private TMP_Text type;

    public void SetCardData(string cardName, string cardDescription, int cardAtk, int cardDef, Sprite cardImage, string cardType)
    {
        title.text = cardName;
        description.text = cardDescription;
        atk.text = "ATK: " + cardAtk.ToString();
        def.text = "DEF: " + cardDef.ToString();
        type.text = "Tipo: " + cardType;

        art.sprite = cardImage;
    }
}
