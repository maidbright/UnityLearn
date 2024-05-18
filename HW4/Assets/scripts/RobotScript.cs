using UnityEngine;

public class RobotScript : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float rotateSpeed = 4.0f;
    public GameObject prefab;
    public bool IsTrig;
    private Collider otherColl;

    private Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float sideMove = Input.GetAxis("Horizontal") * rotateSpeed;
        if (sideMove != 0)
        {
            body.angularVelocity = new Vector3(0.0f, sideMove, 0.0f);
        }

        float forwardMove = Input.GetAxis("Vertical") * moveSpeed;
        if (forwardMove != 0)
        {
            body.velocity = body.transform.forward * forwardMove;
        }
        if (Input.GetKeyDown(KeyCode.Space) && IsTrig == true)
        {
            otherColl.GetComponent<StandScript>().Instatination(gameObject.transform);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        IsTrig = true;
        otherColl = other;
    }
}
