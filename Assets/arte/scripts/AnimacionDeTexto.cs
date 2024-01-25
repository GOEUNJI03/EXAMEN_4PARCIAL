using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionDeTexto : MonoBehaviour
{
    [SerializeField] private GameObject logo;
    [SerializeField] private GameObject btnnewplayer;
    [SerializeField] private GameObject btnjson;
    [SerializeField] private GameObject btnscriptableobject;
    [SerializeField] private GameObject btnaddinglist;
    [SerializeField] private GameObject btnBack;
    [SerializeField] private GameObject btnBack2;
    [SerializeField] private GameObject btnBack3;
    [SerializeField] private GameObject btnBack4;
    [SerializeField] private GameObject name;
    [SerializeField] private GameObject clase;
    [SerializeField] private GameObject descripcion;
    [SerializeField] private GameObject ataque;
    [SerializeField] private GameObject defensa;
    [SerializeField] private GameObject imagen;
    [SerializeField] private GameObject guardarcarta;

    private void Start()
    {
        LeanTween.scale(btnnewplayer.GetComponent<RectTransform>(), new Vector3(4, 12, 4), 1f).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.scale(btnjson.GetComponent<RectTransform>(), new Vector3(4, 12, 4), 1f).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.scale(btnscriptableobject.GetComponent<RectTransform>(), new Vector3(4, 12, 4), 1f).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.scale(btnaddinglist.GetComponent<RectTransform>(), new Vector3(4, 12, 4), 1f).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.moveY(logo.GetComponent<RectTransform>(), 1f, 0).setDelay(4f).setEase(LeanTweenType.easeInSine);
        LeanTween.moveX(btnBack.GetComponent<RectTransform>(), -153, 1f).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.moveX(btnBack2.GetComponent<RectTransform>(),-153, 1f).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.moveX(btnBack3.GetComponent<RectTransform>(),-153, 1f).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.moveX(btnBack4.GetComponent<RectTransform>(),-153, 1f).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.moveY(name.GetComponent<RectTransform>(), 1f, 326).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.moveY(clase.GetComponent<RectTransform>(), 1f, 231).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.moveY(descripcion.GetComponent<RectTransform>(), 1f, 130).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.moveY(ataque.GetComponent<RectTransform>(), 1f, 24).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.moveY(defensa.GetComponent<RectTransform>(), 1f, -82).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.scale(imagen.GetComponent<RectTransform>(), new Vector3(1, 1, 1), 1f).setDelay(2f).setEase(LeanTweenType.easeInSine);
        LeanTween.scale(guardarcarta.GetComponent<RectTransform>(), new Vector3(1, 1, 1), 1f).setDelay(2f).setEase(LeanTweenType.easeInSine);
    }
}
