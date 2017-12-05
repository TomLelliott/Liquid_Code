using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	float speed = 200;
	float posx;
	float posz;
	float posy;

	// Use this for initialization
	void Start () {
		posx = transform.position.x;
		posy = transform.position.y;
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

		if (Input.GetKey (KeyCode.C)) {
			transform.localPosition = new Vector3 (posx, 3f, posz);
		} else {
			transform.localPosition = new Vector3 (posx, 6f, posz);
		
		}

		if (Input.GetKey (KeyCode.C)) {
			transform.localPosition = new Vector3 (posx, posy, posz);
		
		}
	}
}

