using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillLevel : MonoBehaviour
{
	[Range(0.0f, 1.0f)] public float level = 1.0f;
	public Fill fill;

	float topRadius;
	float bottomRadius;
	float maxHeight;

	void Start()
	{
		topRadius = fill.topRadius;
		bottomRadius = fill.bottomRadius;
		maxHeight = fill.height;
	}

	void Update ()
	{
		fill.topRadius = Mathf.Lerp (bottomRadius, topRadius, level);
		fill.height = level * maxHeight;
	}
}
