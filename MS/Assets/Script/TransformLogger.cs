using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformLogger : MonoBehaviour
{
    Transform loggedTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void LoggeCurrentTransform()
    {
        loggedTransform = GameObject.Find("Cube00").transform;
    }
}
