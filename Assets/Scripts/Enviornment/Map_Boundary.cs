using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Boundary : MonoBehaviour
{

    [SerializeField] static float left_bound;
    [SerializeField] static float right_bound;
    public float internal_left;
    public float internal_right;

    private void Start()
    {
      
    }
    void Update()
    {
        internal_left = left_bound;
        internal_right = right_bound;
        
    }
  
    void IsValidBorders()
    {
        
    }
}
