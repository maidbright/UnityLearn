using UnityEngine;

public abstract class BulletScript : MonoBehaviour
{
    protected float destroyTime = 5.0f;
    protected Rigidbody body;
    protected float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        Invoke("OnDestroy", destroyTime);
        // body.velocity = transform.position * speed * Time.deltaTime; 
        //body.AddForce(transform.forward);
        body.velocity = transform.forward * speed;


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
    protected abstract void Fire();

}
