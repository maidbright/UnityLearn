using UnityEngine;

public class MoveObject : MonoBehaviour
{
    InputManager inputManager;

    private void Awake()
    {
        inputManager = InputManager.Instance;
    }
    private void OnEnable()
    {
        inputManager.OnStartTouch += Move;
    }

    private void OnDisable()
    {
        inputManager.OnStartTouch -= Move;
    }

    public void Move(Vector2 scrPos)  //interpr scrpos to coors for  correct cam view
    {
        transform.rotation = Quaternion.Euler(0, scrPos.x, 0);
    }
}
