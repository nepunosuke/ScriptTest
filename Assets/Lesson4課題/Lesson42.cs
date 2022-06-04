using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson42 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int []array={23,44,19,7,32};

        for (int i=4; i>=0; i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
