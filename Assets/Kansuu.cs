using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kansuu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        goodbye();

        HelloName("Unity");

        int sum = Add(3, 6);
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void goodbye()
    {
        Debug.Log("さようなら"); //引数も返り値もない関数
    }

    void HelloName(string name)
    {
        Debug.Log("Hello" + name);//引数だけある関数
    }

    int Add(int a, int b)//引数と返り値両方ある関数
    {
        int c = a + b;
        return c;
    }
}
