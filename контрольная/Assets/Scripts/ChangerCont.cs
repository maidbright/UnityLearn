using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class ChangerCont : MonoBehaviour
{

    protected Collider collider;
    public MonoBehaviour[] behs ;

    private void Start()
    {
        behs[0] = gameObject.GetComponent<ChangeColor>();  //исправть потом
        behs[1] = gameObject.GetComponent<ChangeScale>();
        behs[2] = gameObject.GetComponent<ChangeShape>();
    }


    protected void OnTriggerEnter(Collider other)
    {
        collider = other;
        behs[Random.Range(0,2)].GetComponent<ChangerCont>().ChangeSmth();  //?
    }

    protected abstract void ChangeSmth();
}
