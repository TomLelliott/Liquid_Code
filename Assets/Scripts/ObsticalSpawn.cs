using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalSpawn : MonoBehaviour {

	int RandomNumber;

	public GameObject[] Objects;
	int random = Random.Range(1, 1000000);

	public float count = 0;

	// Use this for initialization
	void Start () {
		RandomNumber = Random.Range (-30, -27);
	}
	
	// Update is called once per frame
	void Update () {
		count += 1;

		if (count >= 100)
			{
				Instantiate (Objects[0], new Vector3(Random.Range(-27,-27), 28), Quaternion.identity);
			count=0;
		}
	
	}
		
}
