using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltGlass : MonoBehaviour
{
	public float angle = 0.0f;

	void Update ()
	{
		transform.rotation = Quaternion.Euler (0.0f, 0.0f, angle);
	}
}
