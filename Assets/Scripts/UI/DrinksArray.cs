using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinksArray : MonoBehaviour {
	public Text myText;

	public static string currentBottle;

	public List<Drink> drinks;

	public Drink theDrink;

	void Start(){
		RandomOrder ();
	}
	// Use this for initialization
	public void RandomOrder () { 
		theDrink = drinks[Random.Range(0, drinks.Count)];
		myText.text = theDrink.name;

	}

	// Update is called once per frame
	void Update () {
		
	}
}
