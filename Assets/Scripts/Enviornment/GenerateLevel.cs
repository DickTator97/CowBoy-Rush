using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using static System.Console;
using static System.Random;
using UnityEngine;


public class GenerateLevel : MonoBehaviour
{
    
    public GameObject[] section;
    public int zPos = 30;
    public bool creatingSection = false;
    public int secNum;



    
    
        
    

   
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());

        }

    }
    IEnumerator GenerateSection()
    {
        secNum = UnityEngine.Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0,zPos), Quaternion.identity);
        zPos += 10;
        yield return new WaitForSeconds(3);
        creatingSection = false;
    }
}
