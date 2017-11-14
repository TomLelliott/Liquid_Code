using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	float speed = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.down * speed * Time.deltaTime);
		}	
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up * speed * Time.deltaTime);
		}	
	}
}
