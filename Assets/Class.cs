using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //体力
    private int power = 25;//攻撃力

    //課題
    private int mp = 53;

    //攻撃用の関数

    public void Attak()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Diffence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");

        //残りhpを減らす
        this.hp -= damage;
    }

    //課題    
    public void Magic()  //魔法用の関数
    {
        if (mp > 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りのmpは" + mp);
        }
        else if (mp < 5)
        {
            Debug.Log("MPが足りないため魔法が使えない.");
        }
    }
}

public class Class : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Bossクラスの変数を宣言して、インスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attak();

        //防御用の関数を呼び出す
        lastboss.Diffence(5);  //引数に注意


        //課題
        for (int t = 0; t < 11; t++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
