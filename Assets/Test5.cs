using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //money��50�ŏ���������
        int money=200;

        if (money>=100)
        {
            //money��100�ȏゾ�����ꍇ
            Debug.Log("�|�[�V�����𔃂�");

        }
        else
        {
            //money��100�����������ꍇ
            Debug.Log("����𔄂�");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
