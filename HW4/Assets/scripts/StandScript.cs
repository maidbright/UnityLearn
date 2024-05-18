using UnityEngine;

public class StandScript : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    public void Instatination(Transform _transform)
    {
        var prefabTr = gameObject.transform;
        prefabTr = _transform;
        Instantiate(prefab, prefabTr.position, Quaternion.identity); //robot's pos-n 'll be replaced bec of rb
    }
}
