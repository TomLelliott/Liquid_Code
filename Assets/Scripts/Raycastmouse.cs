using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycastmouse : MonoBehaviour {

	public Camera camera;

	void Update(){
		RaycastHit hit;
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out hit) && Input.GetKeyDown(KeyCode.Mouse0)) {
			Debug.Log ("ObjectHit");

		}
	}
}