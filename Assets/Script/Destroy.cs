﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.gameObject.transform.position.z < Camera.main.transform.position.z)
        {
            Destroy(this.gameObject);
        }
	}
}
