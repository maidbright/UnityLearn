using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour, IPointerClickHandler
{
    public Dropdown menu;
    private GameObject tmpGO;
    void Start()
    {
        menu = GetComponent<Dropdown>();
        tmpGO = menu.GetComponent<InfoController>().CreateTMPObject();//
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        tmpGO = menu.GetComponent<InfoController>().SetTMPObject(tmpGO, menu.itemText.ToString());//
    }
}
