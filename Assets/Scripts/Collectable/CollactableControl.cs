using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectableControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;



    void Update()
    {
        coinCountDisplay.GetComponent<TextMeshPro>().text = "" + coinCount;
    }
}


