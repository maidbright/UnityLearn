using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : ChangerCont
{
    private Material[] materials;
    private Material currmaterial;
    protected MeshRenderer meshr;


    protected override void ChangeSmth()
    {
        currmaterial = meshr.GetComponent<MeshRenderer>().material;
        currmaterial = materials[Random.Range(1, 3)];
        
    }

}
