using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private InputControl inputControl;
    private void Awake()
    {
        inputControl = new InputControl();
    }

    private void Start()
    {
        inputControl.Touch.TouchPosition.performed += ctx => RotateToDelta(ctx);
        //inputControl.Touch.TouchPosition.started += ctx => RotateToDelta(ctx);
       // inputControl.Touch.TouchPosition.canceled += ctx => RotateToDelta(ctx);

    }


    private void OnEnable()
    {
        inputControl.Enable();
    }


    private void OnDisable()
    {
        inputControl.Touch.TouchPosition.performed -= ctx => RotateToDelta(ctx);
        inputControl.Disable();

       //inputControl.Touch.TouchPosition.started -= ctx => RotateToDelta(ctx);
       //inputControl.Touch.TouchPosition.canceled -= ctx => RotateToDelta(ctx);

    }

    public void RotateToDelta(InputAction.CallbackContext context)  //interpr scrpos to coors for correct cam view
    {
        var scrPos = inputControl.Touch.TouchPosition.ReadValue<Vector2>();
        //Debug.Log(scrPos);
        transform.Rotate(0.0f, scrPos.y, 0.0f);
    }

}


