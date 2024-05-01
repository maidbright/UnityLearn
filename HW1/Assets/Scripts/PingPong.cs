using UnityEngine;

public class PingPong : MonoBehaviour
{
    // PingPong ‒ движется из одной точки в другую и обратно --x,y 
    // Start is called before the first frame update
    private Vector3 targetPosition = new Vector3 (5.0f, 5.0f, 0.0f);
    private Vector3 zeroPosition = new Vector3(0.0f, 0.0f, 0.0f);
    private float speed = 10.0f;
    private bool flag = true;
    void Start()
    {
        transform.position = zeroPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            if (transform.position != targetPosition)
                MoveForward();

            if (transform.position == targetPosition)
                flag = false;
        }
        else
        {
            if (transform.position != zeroPosition)
                MoveBack();

            if (transform.position == zeroPosition)
                flag = true;
        }

    }
    void MoveBack()
    {
        transform.position = Vector3.MoveTowards(transform.position, zeroPosition, speed*Time.deltaTime);
    }
    void MoveForward()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
