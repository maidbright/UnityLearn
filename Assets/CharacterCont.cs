using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCont : MonoBehaviour
{
    public float movementSpeed = 10.0f;
    public float rotationSpeed = 0.2f;

    Animator animator;
    CharacterController characterController;
    Camera charCamera;
    float rotationAngle = 0.0f;
    bool isMoving = false;

public CharacterController CharacterController
    { get { return characterController = characterController ?? GetComponent<CharacterController>(); } }
public Camera CharCamera
    { get { return charCamera = charCamera ?? FindObjectOfType<Camera>(); } }

    public Animator Animator
    {
        get { return animator = animator ?? GetComponent<Animator>(); 
    }
}

    // Update is called once per frame
    void Update()
    {
        float vert = Input.GetAxis("Vertical");
        float horiz = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horiz,0.0f,vert);
        Vector3 rotatedMovement = Quaternion.Euler(0.0f, CharCamera.transform.rotation.eulerAngles.y,0.0f)*movement.normalized; //roation in movement

        CharacterController.Move(rotatedMovement * movementSpeed * Time.deltaTime);

        if(rotatedMovement.sqrMagnitude > 0.0f)
        { 
            if(!isMoving)
            {
                Animator.Play("Run");
            }
            isMoving = true;
        
            rotationAngle = Mathf.Atan2(rotatedMovement.x, rotatedMovement.y) * Mathf.Rad2Deg;
        }
        else
        {
            if(isMoving) 
            {
                Animator.Play("Idle");
            }
            isMoving = false;
        }
        Quaternion currRotation = characterController.transform.rotation;
        Quaternion targRotation = Quaternion.Euler(0.0f, rotationAngle, 0.0f);
        characterController.transform.rotation = Quaternion.Lerp(currRotation, targRotation, rotationSpeed);
    }
}
