using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropdownController : MonoBehaviour, IPointerClickHandler
{
    public TMP_Dropdown menu;
    private GameObject tmpGO;
    void Start()
    {
        menu = GetComponent<TMP_Dropdown>();
        tmpGO = menu.GetComponent<InfoController>().CreateTMPObject();//
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        tmpGO = menu.GetComponent<InfoController>().SetTMPObject(tmpGO, menu.name);//
    }
}
