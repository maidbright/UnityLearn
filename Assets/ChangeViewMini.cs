using UnityEngine;
using UnityEngine.UI;

public class ChangeViewMini : MonoBehaviour
{
    float angleStep = 90.0f;
    private Button button;
    public GameObject minicam;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => { ChangeView(button); }) ;
    }
    public void ChangeView(Button pressedButton)  //interpr scrpos to coors for  correct cam view
    {
        Debug.Log("Button was");
        if(pressedButton != null)
        {
            switch (pressedButton.name)
            {
                case "cameraUp":
                    minicam.transform.rotation = Quaternion.Euler(angleStep,0,0);
                    break;
                case "cameraDown":

                    minicam.transform.rotation = Quaternion.Euler(-angleStep, 0, 0);
                    break;
                case "cameraLeft":

                    minicam.transform.rotation = Quaternion.Euler( 0, -angleStep, 0);
                    break;
                case "cameraFace":

                    minicam.transform.rotation = Quaternion.Euler(0, angleStep*2, 0);
                    break;
            }
        }
    }
}
