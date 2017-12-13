using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServingDrink : MonoBehaviour {

	public CheckOrder Mang;
	public Order NewOrder;

	void Start(){

		Mang = GameObject.FindObjectOfType<CheckOrder>();
		NewOrder = GameObject.FindObjectOfType<Order>();
	}
	void OnTriggerEnter (Collider col){
		if (col.gameObject.CompareTag("Glass")) {
			Mang.Check();
			NewOrder.GetComponent<Order> ().RandomOrder();
		}
	}
}
