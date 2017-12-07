using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelect : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

		if (Physics.Raycast(ray, out hit, 10) && Input.GetKeyDown(KeyCode.Mouse1)) {
			ItemSelect selection = hit.collider.GetComponent<ItemSelect> ();

			if (selection != null) {
				selection.hold (transform);
			}
				
		}
	}
}
