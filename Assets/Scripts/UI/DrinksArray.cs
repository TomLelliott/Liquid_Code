using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinksArray : MonoBehaviour {
	public Text myText;

	public List<Ingredient> drinkIngredients;
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
	public static string currentBottle;

	public string theDrink;

	void Start(){
		RandomOrder ();
	}
	// Use this for initialization
	public void RandomOrder () { 
		theDrink = Drinks[Random.Range(0, Drinks.Length)];
		myText.text = theDrink;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
