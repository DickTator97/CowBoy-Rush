using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBoundry : MonoBehaviour
{

    public static float left_bound=-4.57f;
    public static float right_bound=4.61f;
    public float internal_left;
    public float internal_right;
    void Update()
    {
        internal_left = left_bound;
        internal_right = right_bound;
        
    }
}
