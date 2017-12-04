using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidSpill : MonoBehaviour {
	public GameObject spilt;
	// Use this for initialization
	void Start () {
		spilt = GameObject.Find ("Spillagefill");
	}
	
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.CompareTag ("Liquid")) {
			spilt.GetComponent<spillagebar> ().SpiltLiquid();
		}

	}
}
