using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // num��1�ŏ���������
        int num=1;
        //val�ɑ������l�������ɂ���ĕς���(�O�����Z�q)
        int val=(num==1)?-100:100;
        //val�̒l��\������
        Debug.Log(val);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
