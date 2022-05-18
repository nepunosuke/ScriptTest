using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 処理を繰り返す : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //5回処理を繰り返す
        for(int i=0; i<20;i+=3)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
