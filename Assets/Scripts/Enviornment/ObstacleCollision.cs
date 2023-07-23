using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<CapsuleCollider>().enabled = false;
        thePlayer.GetComponent<Player_Movement>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");

    }




}
