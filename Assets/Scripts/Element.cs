using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Types
{
    red = 0,
    blue = 1,
    green = 2
}


public class Element : MonoBehaviour
{
    public Types type;
    [HideInInspector] public MeshRenderer mesh;

    private void Start()
    {
        TryGetComponent(out mesh);
    }
}
