using UnityEngine;

public abstract class BulletScript : MonoBehaviour
{
    protected float destroyTime = 5.0f;
    protected Rigidbody body;
    protected float speed = 70.0f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Invoke("OnDestroy", destroyTime);
        // body.velocity = transform.position * speed * Time.deltaTime; 
        //body.AddForce(transform.forward);

    }

    void OnDestroy()
    {
        Destroy(this.gameObject); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    protected abstract void Fire();

}
