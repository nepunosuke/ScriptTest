using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int money=200;
        if (money<=50)
        {
            Debug.Log("����𔄂�");
        }
        else if(money>=200)
        {
            Debug.Log("����𔃂�");
        }
        else
        {
            Debug.Log("�|�[�V�����𔃂�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
