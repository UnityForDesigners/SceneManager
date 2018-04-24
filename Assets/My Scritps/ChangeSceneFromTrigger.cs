﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneFromTrigger : MonoBehaviour {

	void OnTriggerEnter (Collider hit){

		if (hit.tag == "Player") {
			SceneManager.LoadScene ("Scene02"); 

		}

	}
}
