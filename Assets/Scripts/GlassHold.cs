using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassHold : MonoBehaviour {
	new public Camera camera;
	new Collider collider;

	void Update(){
		RaycastHit hit;
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);

		if (collider.Raycast(ray, out hit, 100) && Input.GetKeyDown(KeyCode.Mouse1)) {

		}
	}
}
