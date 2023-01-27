using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatMaterialSwitch : MonoBehaviour
{
    public Material cloth;
    public Material leather;
    public Material blank;
    public MeshRenderer matMaterialRender;

    // Start is called before the first frame update
    void Start()
    {
        matMaterialRender = gameObject.GetComponent<MeshRenderer>();
    }


    public void SwitchToCloth()
    {
        matMaterialRender.material = matMaterialRender.material.name.StartsWith(cloth.name) ? cloth : cloth;
    }

    public void SwitchToLeather()
    {
        matMaterialRender.material = matMaterialRender.material.name.StartsWith(leather.name) ? leather : leather;
    }
}
