using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //処理を５回繰り返す
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        //sumを０で初期化する
        int sum = 0;

        //10回処理を繰り返す
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }

        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
