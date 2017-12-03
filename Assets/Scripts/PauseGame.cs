using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

	public GameObject Pause;

	void Start() {
		Time.timeScale = 1;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {

			if (Time.timeScale == 1)
				Time.timeScale = 0;
			else
				Time.timeScale = 1;
		}
		if (Time.timeScale == 0) {
			Pause.SetActive (true);
		}
		else
			Pause.SetActive (false); 
		
			}
	}

