using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class ChangeColor : MonoBehaviour
{
    Button button;
    GameObject _currGO;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => { ChangeGameObject(button); });

    }
    public void ChangeGameObject(Button button) //++
    {

        _currGO = GameObject.FindWithTag("Plane");
        var color = button.GetComponent<Image>().color;
        _currGO.GetComponentInChildren<MeshRenderer>().material.color = color;


    }

}
