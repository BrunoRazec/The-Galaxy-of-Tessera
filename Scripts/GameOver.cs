﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene ("Lv1");
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("Menu");
		}
	}
}
