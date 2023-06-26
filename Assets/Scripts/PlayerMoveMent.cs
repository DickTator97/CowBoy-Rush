using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveMent : MonoBehaviour
{
    //movment
    //1. move player forward with add force
    //2. move player sideways with touch input
    //3. make player jump while dragging finger upwards
    //4. make player slide while dragging finger downwards


    //score
    //life 
    //animations (if exisiting)

    Rigidbody rb;
    GameObject ObjectToMove;
    Vector3 MoveMentDirection;
    SerializeField Speed;
    SerializeField MaxSpeed;
    SerializeField Acceleration;
    SerializeField JumpForce;
    
    
    // Start is called before the first frame update
    void Start()
    {
        MoveMentDirection = new Vector3(0, 0, 0);
        ObjectToMove.transform.position = MoveMentDirection;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
