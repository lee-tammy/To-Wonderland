﻿using UnityEngine;
using System.Collections;

public class destroywhenover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel == 0) {
			Destroy (gameObject);
		}
	
	}
}
