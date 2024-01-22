using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardJsonManager : MonoBehaviour
{
    [SerializeField] private TMP_Text Name;
    [SerializeField] private TMP_Text description;
    [SerializeField] private TMP_Text Class;
    [SerializeField] private TMP_Text atk;
    [SerializeField] private TMP_Text def;

    public void SetName(TMP_Text _name, TMP_Text _description,TMP_Text _Class, int _atk, int _def)
    {
        Name.text = Name.text;
        description.text = description.text;
        Class.text = Class.text;
        atk.text = _atk.ToString();
        def.text = _def.ToString();
    }
}
