using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillLevel : MonoBehaviour{
	[Range(0.0f, 1.0f)] public float level = 1.0f;
	public Fill fill;

	float topRadius;
	float bottomRadius;
	float maxHeight;

	float PosX;
	float PosZ;

	void Start()
	{
		topRadius = fill.topRadius;
		bottomRadius = fill.bottomRadius;
		maxHeight = fill.height;
		PosX = transform.rotation.x;
		PosZ = transform.rotation.z;
	}

	void Update ()
	{
		fill.topRadius = Mathf.Lerp (bottomRadius, topRadius, level);
		fill.height = level * maxHeight;
		float tip = Vector3.Angle (transform.up, Vector3.up);
		level = Mathf.Min (level, 1.0f - Mathf.InverseLerp (0.0f, 100.0f, tip));
	}
}
