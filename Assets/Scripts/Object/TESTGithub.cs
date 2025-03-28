using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTGithub : MonoBehaviour
{
    public float Test1 = 5.0f;
    public float Test2 = 5.0f;
    public float ppp;

    public void test()
    {
        ppp = Test1 + Test2 ;
        Debug.Log(ppp);
    }

    private void Start()
    {
        test();
    }
}
