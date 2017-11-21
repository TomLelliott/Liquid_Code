using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface : MonoBehaviour
{
	[Range(0.01f, 0.03f)] public float radius = 0.02f;

	void Update ()
	{
		transform.localScale = new Vector3 (radius, 0.0002f, radius);
	}
}
