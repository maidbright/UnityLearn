using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShape : ChangerCont
{
    //private Collider Collider;
    public Mesh[] meshs;
    protected Mesh currMesh;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    protected override void ChangeSmth()
    {
        currMesh = collider.GetComponent<Mesh>();
        currMesh = meshs[Random.Range(1, 3)];
    }
}
