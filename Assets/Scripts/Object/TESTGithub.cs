using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTGithub : MonoBehaviour
{
    public float Test1 = 5.0f;
    public float Test2 = 5.0f;
    public float Test3 = 5.0f;
    public float Test4 = 5.0f;
    public float ppp;
    public float sum;

    public void test()
    {
        ppp = Test1 + Test2 ;
        ppp2 = Test3 + Test4 ;
        sum = ppp + ppp2 ;
        Debug.Log(ppp);
        Debug.Log(ppp2);
        Debug.Log(sum);
    }

    private void Start()
    {
        test();
    }
}
