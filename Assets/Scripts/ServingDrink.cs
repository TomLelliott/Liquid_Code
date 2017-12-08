using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServingDrink : MonoBehaviour {

	public GameObject Mang;

	void Start(){
		Mang = GameObject.Find ("CheckOrder");
	}
	void OnTriggerEnter (Collider col){
		if (col.gameObject.CompareTag("Glass")) {
			Mang.GetComponent<CheckOrder>().Check();
		}
	}
}
