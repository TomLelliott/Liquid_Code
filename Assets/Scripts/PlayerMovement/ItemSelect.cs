using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelect : MonoBehaviour {

	new public Camera camera;
	new Collider collider;
	bool Holding = false;
	Vector3 lastMousePosition;
	float speed = 100;
	private Rigidbody Rb;
	void Start()
	{
		collider = GetComponent<Collider> ();
		Rb = GetComponent<Rigidbody> ();
	}

	void Update(){
		RaycastHit hit;
		Ray ray = camera.ScreenPointToRay(Input.mousePosition);

		if (collider.Raycast(ray, out hit, 100) && Input.GetKeyDown(KeyCode.Mouse1)) {
			Holding = true;
			Rb.isKinematic = true;

		}

		if (Holding) {
			Vector3 mouseMove = Input.mousePosition - lastMousePosition;
			transform.localPosition = transform.localPosition - Vector3.left * mouseMove.x / Screen.width;
			transform.localPosition = transform.localPosition + Vector3.up * mouseMove.y / Screen.width;

		}

		if (Input.GetKey (KeyCode.A) && Holding) {
			transform.Rotate (Vector3.forward * speed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.D) && Holding) {
			transform.Rotate (Vector3.back * speed * Time.deltaTime);
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && Holding) {
			Holding = false;
			Rb.isKinematic = false;
		}

		lastMousePosition = Input.mousePosition;


	}
}