using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleMovement : MonoBehaviour {

	public Camera camera;
	bool Holding = false;
	Vector3 lastMousePosition;
	float speed = 50;

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
			transform.position = transform.position + Vector3.up * mouseMove.y / Screen.width;

			if (Input.GetKey (KeyCode.A)) {
				transform.Rotate (Vector3.forward * speed * Time.deltaTime);
			}

			if (Input.GetKey (KeyCode.D)) {
				transform.Rotate (Vector3.back * speed * Time.deltaTime);
			}
		}

		if (Input.GetKeyDown (KeyCode.Mouse1)) {
			Holding = false;
		}
		lastMousePosition = Input.mousePosition;
	

	}
}