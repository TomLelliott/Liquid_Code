using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fill : MonoBehaviour
{
	public int circleVertices = 20;
	[Range(0.001f, 0.1f)] public float topRadius = 0.02f;
	public float bottomRadius = 0.018f;
	[Range(0.001f, 0.2f)] public float height = 0.032f;

	Mesh mesh;

	void Start ()
	{
		//gameObject.AddComponent<MeshFilter>();
		//gameObject.AddComponent<MeshRenderer>();
		mesh = GetComponent<MeshFilter>().mesh;

		mesh.Clear();

		List<Vector3> vertexList = new List<Vector3>();
		List<int> triangleList = new List<int> ();
		// top surface
		CreateCircleVertices (vertexList, height, topRadius);
		CreateCircleTriangles (triangleList, 0, true);
		// bottom surface
		CreateCircleVertices (vertexList, 0.0f, bottomRadius);
		CreateCircleTriangles (triangleList, 21, false);

		for (int i = 0; i < circleVertices; ++i) 
		{
			int nextIndex = (i + 1) % circleVertices;

			triangleList.Add (i + 1);
			triangleList.Add (i + 22);
			triangleList.Add (nextIndex + 22);
			triangleList.Add (i + 1);
			triangleList.Add (nextIndex + 22);
			triangleList.Add (nextIndex + 1);
		}

		mesh.vertices = vertexList.ToArray ();
		mesh.triangles = triangleList.ToArray ();
//		mesh.vertices = new Vector3[] {new Vector3(0, 0, 0), new Vector3(0, 1, 0), new Vector3(1, 1, 0)};
//		mesh.uv = new Vector2[] {new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 1)};
//		mesh.triangles =  new int[] {0, 1, 2};		
	}

	void CreateCircleVertices(List<Vector3> vertexList, float y, float r)
	{
		vertexList.Add (new Vector3 (0.0f, y, 0.0f));
		float angle = 0.0f;
		float angleStep = 360.0f / (float)circleVertices;
		for (int i = 0; i < circleVertices; ++i) {
			vertexList.Add (new Vector3 (Mathf.Sin (angle * Mathf.Deg2Rad) * r, y, Mathf.Cos (angle * Mathf.Deg2Rad) * r));
			angle += angleStep;
		}
	}

	void CreateCircleTriangles(List<int> triangleList, int startIndex, bool faceUp)
	{
		for (int i = 0; i < circleVertices; ++i) 
		{
			triangleList.Add (startIndex);
			if (faceUp) 
			{
				triangleList.Add (i + startIndex + 1);
				triangleList.Add (((i + 1) % circleVertices) + startIndex + 1);
			} 
			else 
			{
				triangleList.Add (((i + 1) % circleVertices) + startIndex + 1);
				triangleList.Add (i + startIndex + 1);
			}
		}
	}

	void Update()
	{
		List<Vector3> vertexList = new List<Vector3>();
		CreateCircleVertices (vertexList, height, topRadius);
		CreateCircleVertices (vertexList, 0.0f, bottomRadius);
		mesh.vertices = vertexList.ToArray ();
	}
}
