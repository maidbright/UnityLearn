using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    //вращается в определенном направлении и с заданной скоростью++
    // Start is called before the first frame update
    public float speed = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(new Vector3(0,0,0),new Vector3(speed,0,0), speed * Time.deltaTime);
        //transform.Rotate(Vector3.forward, speed * Time.deltaTime);
    }
}
