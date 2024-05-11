using TMPro;
using UnityEngine;

public class InfoController : MonoBehaviour
{
    public GameObject prefab;
    public Transform canvas;
    private GameObject instance;
    public GameObject CreateTMPObject()
    {
        instance = Instantiate(prefab);
        instance.transform.SetParent(canvas.transform, false);
        instance.SetActive(false);
        return instance;
    }
    public GameObject SetTMPObject(GameObject gameObject, string buttonName)
    {
        var txt = gameObject.GetComponent<TextMeshProUGUI>();
        txt.SetText($"{buttonName} was clicked");
        gameObject.SetActive(true); 
        return gameObject;
    }

    public void DestroyTMPObject(TextMeshProUGUI gameObjectTMP)
    {
        Destroy(gameObjectTMP);
    }
}
