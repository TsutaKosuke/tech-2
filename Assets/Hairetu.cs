using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hairetu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] points = new int[5];//要素５の配列を初期化する

        //配列の各要素に値を代入する
        points[0] = 30;
        points[1] = 40;
        points[2] = 50;
        points[3] = 60;
        points[4] = 70;

        //配列の要素を全て表示する
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]); //iを配列のインデックスに使うことで、配列の各要素へ順番にアクセスしている。
        }

        //＿＿＿＿＿＿＿＿応用＿＿＿＿＿＿＿＿＿↓

        //配列を初期化する
        int[] point = { 30, 20, 50, 10, 80, 15, 60, 100 };

        //配列の要素数の分だけ処理を繰り返す
        for (int t = 0; t < point.Length; t++)　　//Lengthは配列の長さを示す
        {
            //配列の要素が５０以上の場合
            if (point[t] >= 50)
            {
                //配列の要素を表示する
                Debug.Log(point[t]);
            }
        }


        //課題

        int[] array = new int[5];

        array[0] = 25;
        array[1] = 30;
        array[2] = 70;
        array[3] = 50;
        array[4] = 100;

        for (int p = 0; p < 5; p++)
        {
            Debug.Log(array[p]);
        }

        for (int o = 4; o > -1; o--)
        {
            Debug.Log(array[o]);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
