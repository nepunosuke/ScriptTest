using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 引数も返り値もない関数 : MonoBehaviour
{
    //「Hello, UnityChan」と表示する関数
    void Hello()
    {
        Debug.Log("Hello,UnityChan");
    }
    void Goodbye()
    {
        Debug.Log("Goodbye,UnityChan");
    }
    // Start is called before the first frame update
    void Start()
    {
        //Hello関数を引き出す
        Hello();
        Goodbye();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
