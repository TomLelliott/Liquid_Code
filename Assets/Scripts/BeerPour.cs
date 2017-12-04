using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerPour : MonoBehaviour {

	public GameObject Pump;
	public GameObject Beer;

	// Use this for initialization
	void updat () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.CompareTag ("Glass")) {
			Pump.transform.eulerAngles = new Vector3 (0, 0, 45f);
			Instantiate (Beer, new Vector3(-6,5,1), Quaternion.identity);
		}
		else 
		{
			Pump.transform.eulerAngles = new Vector3 (0, 0, 45f);
		}
	}
}
