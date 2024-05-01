using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Createprefab : MonoBehaviour
{
    public GameObject[] prefab;
    private GameObject instance;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (prefab == null)
            {
                Debug.Log("Warning! The instance is empty");
                return;
            }
            if (instance != null) 
            {
                Destroy(instance);
            }
            var value = Random.Range(0, prefab.Length);
            var rotation = Quaternion.identity; //default pos-n
            var position = new Vector3(Random.Range(-5.0f, 5.0f),Random.Range(-5.0f, 5.0f)) ;
            instance = Instantiate(prefab[value],position, rotation);

        }
    }
}
