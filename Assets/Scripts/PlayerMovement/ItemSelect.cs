using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemSelect : MonoBehaviour {

	new Collider collider;
	bool Holding = false;
	Vector3 lastMousePosition;
	float speed = 500;
	private Rigidbody Rb;
//	public float count = 0;

	void Start()
	{
		collider = GetComponent<Collider> ();
		Rb = GetComponent<Rigidbody> ();
	}

	public void hold(Transform parent){
		Holding = true;
		Rb.isKinematic = true;
		transform.parent = parent;
		transform.rotation = Quaternion.LookRotation (transform.forward, Vector3.up);

		if (Rb.CompareTag("Bottle")) {
			DrinksArray.currentBottle = name;
			print ("Bottle:" + name);
	
		}


	}
	void Update(){
	//	if (Holding == true) {
		//	count += 1;
		//}

		//if (count >= 100){
		//	SceneManager.LoadScene ("Tutorial");
	//	}

		if (Holding) {
			Vector3 mouseMove = Input.mousePosition - lastMousePosition;
			transform.localPosition = transform.localPosition - Vector3.left * mouseMove.x / Screen.width;
			transform.localPosition = transform.localPosition + Vector3.up * mouseMove.y / Screen.width;

		}

		if (Input.GetAxis("Mouse ScrollWheel") > 0 && Holding) {
			transform.Rotate (Vector3.right * speed * Time.deltaTime);
		}

		if (Input.GetAxis("Mouse ScrollWheel") < 0 && Holding) {
			transform.Rotate (Vector3.left * speed * Time.deltaTime);
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && Holding) {
			Holding = false;
			Rb.isKinematic = false;
			transform.parent = null;
		}

		lastMousePosition = Input.mousePosition;


	}
}