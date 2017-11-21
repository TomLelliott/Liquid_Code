using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltGlass : MonoBehaviour
{
	public FillLevel level;
	public float angle = 0.0f;

	void Update ()
	{
		transform.rotation = Quaternion.Euler (0.0f, 0.0f, angle);
	}
	void OnCollisionEnter (Collision Hit){
		if (Hit.gameObject.CompareTag ("Liquid")) {
			level.level += 0.01f;
		}
	}

}
