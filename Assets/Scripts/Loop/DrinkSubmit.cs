using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkSubmit : MonoBehaviour {

	public List<string> Drinks = new List<string>();
	// Use this for initialization
	void Start () {

		Drinks.Add("Beer");
		Drinks.Add("RedWine");
		Drinks.Add("WhiteWine");
		Drinks.Add("Rum");
		Drinks.Add("Whisky");
		Drinks.Add("Vodka");
		Drinks.Add("Coke");
		Drinks.Add("Lemonade");

	
		foreach(string Drink in Drinks)
		{
			
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
