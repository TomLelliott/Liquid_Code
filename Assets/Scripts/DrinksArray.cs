using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinksArray : MonoBehaviour {
	public Text myText;
	public string[] Drinks =
	{
		"Red Wine",
		"White Wine",
		"Beer",
		"Rum and Coke",
		"Rum and Lemonade",
		"Whisky and Coke",
		"Whisky and Lemonade",
		"Vodka and Coke",
		"Vodka and Lemonade"
	};

		
	// Use this for initialization
	void Start () {
		string myString = Drinks[(Drinks.Length)];
		myText.text = myString;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
