using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerPour : MonoBehaviour {

	public GameObject Pump;
	public GameObject Beer;
	bool Pour = false;

	// Use this for initialization
	void Update () {
		if(Pour== true){
			Pump.transform.eulerAngles = new Vector3 (0, 0, 45f);
			Instantiate (Beer, new Vector3 (-6.1f, 5.6f, 1.3f), Quaternion.identity);
		}
		else 
		{
			Pump.transform.eulerAngles = new Vector3 (0, 0, 0f);
		}
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.CompareTag ("Glass")) {
			Pour = true;
		}
	}

	void OnTriggerExit (Collider col)
		{
			if (col.gameObject.CompareTag ("Glass")) {
				Pour = false;
			}
	}
}
