using UnityEngine;

public class Scaler : MonoBehaviour
{  //плавно меняет свой размер до какого-то значения.++

    // Start is called before the first frame update
    private Vector3 targetScale = new Vector3(3.0f, 3.0f, 3.0f);
    private float frequency = .5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale=Vector3.Lerp(transform.localScale,targetScale, frequency * Time.deltaTime);
    }
}
