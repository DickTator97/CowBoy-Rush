using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream:Assets/Scripts/Enviornment/MapBoundry.cs
public class MapBoundry : MonoBehaviour
=======
public class Map_Boundary : MonoBehaviour
>>>>>>> Stashed changes:Assets/Scripts/Enviornment/Map_Boundary.cs
{

    public static float left_bound=-4.57f;
    public static float right_bound=4.61f;
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
<<<<<<< Updated upstream:Assets/Scripts/Enviornment/MapBoundry.cs
=======
  
    void IsValidBorders()
    {
        
    }
>>>>>>> Stashed changes:Assets/Scripts/Enviornment/Map_Boundary.cs
}
