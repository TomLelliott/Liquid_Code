using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	
	public float starttime;
	private Text thetext;
	public GameObject gameover;
	public GameObject gameover2;
	public GameObject Ticket;
	public GameObject text;


	// Use this for initialization
	void Start () {
		thetext = GetComponent<Text> ();
		gameover.SetActive (false);
		gameover2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		starttime -= Time.deltaTime;
		thetext.text = "" + Mathf.Round (starttime);

		if (starttime <= 0) {
			gameover.SetActive (true);
			gameover2.SetActive (true);
			Ticket.SetActive (false);
			text.SetActive (false);
		}

}
}
