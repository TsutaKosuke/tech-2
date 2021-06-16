using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kasu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        int[] hanage = { 15, 20, 60, 45, 90 };

        for (int k = 0; k < hanage.Length; k++)
        {
            if (hanage[k] > 50)
            {
                Debug.Log(hanage[k]);
            }
               
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
