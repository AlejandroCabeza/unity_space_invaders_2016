﻿using UnityEngine;
using System.Collections;

public class BarrierTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    void OnCollisionEnter(Collision coll)
    {
        Debug.Log("COLLISION BARRIER");
    }
}
