using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShowControl : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Cessna Main Plane").SetActive(false);
    }
}
