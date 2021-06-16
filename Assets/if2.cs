using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int num = 1;

        int val = (num == 1) ? -100 : 100;

        Debug.Log(val);

        int a = 3;
        int b;

        if (a  == 3)
        {
            b = 5;
            Debug.Log(b);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
