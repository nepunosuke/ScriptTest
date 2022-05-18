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
            Debug.Log("•Ší‚ğ”„‚é");
        }
        else if(money>=200)
        {
            Debug.Log("•Ší‚ğ”ƒ‚¤");
        }
        else
        {
            Debug.Log("ƒ|[ƒVƒ‡ƒ“‚ğ”ƒ‚¤");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
