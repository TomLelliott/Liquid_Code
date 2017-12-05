using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidDestroy : MonoBehaviour {


	// Use this for initialization
	void Start () {
		Destroy (gameObject, 2);
	

	}

	// Update is called once per frame
	void OnTriggerEnter (Collider col){
		if (col.gameObject.CompareTag ("Glass")) {
			Destroy (gameObject);
		}
	}
}