using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwitchController : MonoBehaviour
{
    public Button button;
    public GameObject currGameObject;
    public GameObject nextGameobject;
    // Start is called before the first frame update

    public void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => { if (currGameObject.GetComponent<InfoController>().GetComponent<TextMeshProUGUI>() is not null)
        {
            var tmp = currGameObject.GetComponent<InfoController>().GetComponent<TextMeshProUGUI>();
            currGameObject.GetComponent<InfoController>().DestroyTMPObject(tmp);
        }});

        button.onClick.AddListener(() => { currGameObject.gameObject.SetActive(false); nextGameobject.gameObject.SetActive(true);});
    }
}
