using UnityEngine;
using UnityEngine.UI;

public class SwitchController : MonoBehaviour
{
    public Button button;
    public GameObject[] Planes;
    public int indexer;
    public static GameObject currGO;
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => {currGO = Activate(button.name); });

        GameObject Activate(string buttonName)
        {
            switch (buttonName)
            {
                case "next":
                    Planes[indexer].SetActive(false);
                    if (indexer == Planes.Length - 1)
                    {
                        indexer = -1;
                    }
                    Planes[indexer + 1].SetActive(true);
                    indexer++;
                    break;

                case "prev":
                    Planes[indexer].SetActive(false);
                    if (indexer == 0)
                    {
                        indexer = Planes.Length;
                    }
                    Planes[indexer - 1].SetActive(true);
                    indexer--;
                    break;
            }
            return currGO;
        }
    }
}
