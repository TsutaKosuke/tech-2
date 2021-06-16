using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int money = 100;

        if (money <= 50)
        {
            Debug.Log("武器を売る");
        }
        else if (money >= 200)
        {
            Debug.Log("武器を買う");
        }
        else //それ以外の場合
        {
            Debug.Log("ポーションを買う");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
