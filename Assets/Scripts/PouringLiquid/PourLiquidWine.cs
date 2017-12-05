using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PourLiquidWine : MonoBehaviour {

	public GameObject Wine;
	float Sx;
	float Sy;
	float Sz;

	void Start(){
		Sx = transform.localScale.x;
		Sy = transform.localScale.y;
		Sz = transform.localScale.z;
		Wine.transform.localScale = new Vector3 (0, 0, 0);
	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.CompareTag ("Wine")) {
			Sx += 0.1f;
			Sy += 0.1f;
			Sz += 0.1f;
		}
	}
}
