using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	float speed = 200;
	float posx;
	float posz;
	// Use this for initialization
	void Start () {
		posx = transform.position.x;
		posz = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.down * speed * Time.deltaTime);
		}	

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up * speed * Time.deltaTime);
		}	

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.localPosition = new Vector3 (posx, 0.3f, posz);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.localPosition = new Vector3 (posx, -0.3f, posz);
		}
	}
}
