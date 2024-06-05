using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    private Vector3 position = new Vector3();
    public float speed = 5.0f;
    private float posConstrain = 50.0f;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = RandomizeVector();
        speed *= Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed);
        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            target = RandomizeVector() ; 
        }
    }
    private Vector3 RandomizeVector()
    {
        position = new Vector3(Random.Range(-posConstrain, posConstrain),
        0.0f,
        Random.Range(-posConstrain, posConstrain));

        return position;
    }

    /*var step = speed * Time.deltaTime; // calculate distance to move
    transform.position = Vector3.MoveTowards(transform.position, target.position, step);

    // Check if the position of the cube and sphere are approximately equal.
    if (Vector3.Distance(transform.position, target.position) < 0.001f)
    {
        // Swap the position of the cylinder.
        target.position *= -1.0f;*/
    
}

