using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    [SerializeField] private Card card;
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text description;
    [SerializeField] private Image art;
    [SerializeField] private TMP_Text atk;
    [SerializeField] private TMP_Text def;
    [SerializeField] private Image fond;
    [SerializeField] private Image stars;
    [SerializeField] private Image symbol;
    private void Start()
    {
        title.text = card.name;
        description.text = card.description;
        atk.text = "ATK/" + card.atk.ToString();
        def.text = "DEF/" + card.def.ToString();

        art.sprite = card.image;
        fond.sprite = card.fond;
        stars.sprite = card.str;
        symbol.sprite = card.syb;
    }
}
