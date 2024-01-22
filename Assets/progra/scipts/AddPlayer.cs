using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AddPlayer : MonoBehaviour
{

    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private TMP_InputField descriptionInput;
    [SerializeField] private TMP_InputField atkInput;
    [SerializeField] private TMP_InputField defInput;
    [SerializeField] private TMP_InputField PlayerClassInput;


    void Start()
    {

    }

    public void SetInfoPrefs()
    {
        PlayerPrefs.SetString("name", nameInput.text);
        PlayerPrefs.SetString("description", descriptionInput.text);
        PlayerPrefs.SetString("class", PlayerClassInput.text);
        PlayerPrefs.SetString("atk", atkInput.text);
        PlayerPrefs.SetString("def", defInput.text);
    }

    public void GetInfoPrefs()
    {
        Debug.Log("name" + PlayerPrefs.GetString("name"));
        Debug.Log("description" + PlayerPrefs.GetString("description"));
        Debug.Log("class"+PlayerPrefs.GetString("class"));
        Debug.Log("atk/" + PlayerPrefs.GetString("atk"));
        Debug.Log("def/" + PlayerPrefs.GetString("def"));

    }



}


