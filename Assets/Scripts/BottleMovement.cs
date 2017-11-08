using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleMovement : MonoBehaviour {

	public Camera camera;
	bool Holding = false;
	Vector3 lastMousePosition;

	void Update(){
		RaycastHit hit;
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out hit) && Input.GetKeyDown(KeyCode.Mouse0)) {
			Debug.Log ("ObjectHit");
			Holding = true;

		}

		if (Holding) {
			Vector3 mouseMove = Input.mousePosition - lastMousePosition;
			transform.position = transform.position - Vector3.left * mouseMove.x / Screen.width;
		}

		lastMousePosition = Input.mousePosition;
	}
}