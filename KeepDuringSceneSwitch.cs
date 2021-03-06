﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepDuringSceneSwitch : MonoBehaviour
{
    static KeepDuringSceneSwitch instanceRef;

    void Awake()
    {
        if (instanceRef == null)
        {
            instanceRef = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}