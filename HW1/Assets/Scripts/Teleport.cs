using UnityEngine;

public class Teleport : MonoBehaviour
{   //‒ телепортируется в случайное место каждые N секунд ++
    public float frequency = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        frequency -= Time.deltaTime;
        if (frequency < 0)
        {
            ChangePosition();
            frequency = 5.0f;
        }
        //StartCoroutine(ChangePosition(frequency));
       // StopCoroutine(ChangePosition(frequency));
    }
  // IEnumerator ChangePosition(float frequency)
    void ChangePosition()
    {
        //yield return new WaitForSecondsRealtime(frequency);
        transform.position = new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));
    }
}
