using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp=100;
    private int power=25;

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power+"のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage+"のダメージを受けた");
        //残りhpを減らす
        this.hp -= damage;
    }
}

public class クラスの制作 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss= new Boss (); 

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
