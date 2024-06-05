using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject[] prefabs;
    private GameObject instance;
    private float randValue = 20.0f;
    private Vector3 pos = new Vector3(); 

    // Update is called once per frame
    void Update()
    {
        var value = Random.Range(0, prefabs.Length);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pos.x = Rand();
            pos.y = Mathf.Abs(Rand());
            pos.z = Mathf.Abs(Rand());
            instance = Instantiate(prefabs[value], pos,Quaternion.identity);
            Destroy(instance,30.0f);
        }
    }

    float Rand()
    {
       var position = Random.Range(-randValue, randValue);
        return position;
    }
}
