using UnityEngine;
using UnityEngine.UI;

public class ChangePlane : MonoBehaviour
{
    public Button button;
    public GameObject[] Planes;
    public int indexer;
    GameObject currGo;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => {Activate(button.name); });
    }

    public void Activate(string buttonName)
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

    }


}
