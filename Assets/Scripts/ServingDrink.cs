using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServingDrink : MonoBehaviour {

	public CheckOrder Mang;


	void Start(){

		Mang = GameObject.FindObjectOfType<CheckOrder>();
	}
	void OnTriggerEnter (Collider col){
		if (col.gameObject.CompareTag("Glass")) {
			Mang.Check();

		}
	}
}
