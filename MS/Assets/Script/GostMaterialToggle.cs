using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GostMaterialToggle : MonoBehaviour
{
    public GameObject controller;

    void EnableController()
    {
        controller.SetActive(true);
    }

    void DisableController()
    {
        controller.SetActive(false);
    }
}
