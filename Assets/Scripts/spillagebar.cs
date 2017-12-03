using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spillagebar : MonoBehaviour {

	float MaxSpill=100;
	public float CurrentSpill;

	// Use this for initialization

	void Start () {
	
		CurrentSpill = 0;
	}
	
	// Update is called once per frame
	void Update () {		
	if (CurrentSpill>=100f) {
			SceneManager.LoadScene ("Restart");
		}
	}

	public void SpiltLiquid (){
		CurrentSpill +=0.5f;
		transform.localScale = new Vector3 ( 0.5f, (CurrentSpill / MaxSpill), 0.5f);
	}

}

