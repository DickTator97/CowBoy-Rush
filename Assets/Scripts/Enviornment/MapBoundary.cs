using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBoundary : MonoBehaviour
{

    [SerializeField] static float left_bound=-11;
    [SerializeField] static float right_bound=11;
    public float internal_left;
    public float internal_right;
    void Update()
    {
        internal_left = left_bound;
        internal_right = right_bound;
        
    }
  
}
