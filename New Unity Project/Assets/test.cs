﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int sum = 0;
        for(int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
