using UnityEngine;
using UnityEngine.UI;
public class ToggleController : MonoBehaviour
{
    private GameObject tmpGO;
    private Toggle[] toggles;
    private ToggleGroup toggleGroup;

    void Start() 
    {
        toggles = GetComponentsInChildren<Toggle>();
        tmpGO = toggleGroup.GetComponent<InfoController>().CreateTMPObject();

        foreach (var t in toggles)
        {
            var toggle = t;
            t.onValueChanged.AddListener(on => { if (on) printInfo(toggle); }); //if toggle is selected, call method printInfo
        }
    }
    void printInfo(Toggle toggle)
    {
        tmpGO = toggle.GetComponent<InfoController>().SetTMPObject(tmpGO, toggle.name);
    }
}
      
