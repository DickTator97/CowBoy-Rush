using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<CapsuleCollider>().enabled = true;
        thePlayer.GetComponent<Player_Movement>().enabled = true;
       charModel.GetComponent<Animator>().Play("Stumble Backwards");

    }




}
