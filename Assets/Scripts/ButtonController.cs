using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public Button button;
    private GameObject tmpGO;

    private void Start()
    {
        button = GetComponent<Button>();
        tmpGO = button.GetComponent<InfoController>().CreateTMPObject();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        tmpGO.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        tmpGO = button.GetComponent<InfoController>().SetTMPObject(tmpGO,button.name);
    }
}
