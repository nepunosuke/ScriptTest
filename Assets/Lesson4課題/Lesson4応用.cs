using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LBoss
{
    private int hp=100;
    private int power=25;
    private int mp=53;

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
    public void Magic(int mpcost)
    {
        if (mp>=5)
        {
            Debug.Log("魔法攻撃をした。残りMPは"+this.mp);
            this.mp -= mpcost;
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない");
        }
    }
}

public class Lesson4応用 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        LBoss lastboss= new LBoss (); 

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        lastboss.Magic(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
