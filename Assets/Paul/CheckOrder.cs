using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckOrder : MonoBehaviour
{
	bool tip=false;

	public GameObject CorrectDrink;
	public GameObject WrongDrink;

	public DrinksArray NewOrder;
	public Glass glass;

	public Text Points;
	public Text Extra;
	public Text Wrong;

	public float count = 0;
	public float Point = 0;
	public float CountDownTimer = 20f;

	void Start(){
		NewOrder = GameObject.FindObjectOfType<DrinksArray>();
		CorrectDrink.SetActive (false);
		WrongDrink.SetActive (false);
	}

	void Update(){
		if (WrongDrink.activeInHierarchy) {
			count += 1;
		}

		if (CorrectDrink.activeInHierarchy){
			count += 1;
		}

		if(count >=100){
			CorrectDrink.SetActive (false);
			WrongDrink.SetActive (false);
			count = 0;
		}

		CountDownTimer -= Time.deltaTime;

	}

	public void Check()
    {
		DrinksArray drinks = GetComponent <DrinksArray> ();
		Drink theDrink = drinks.theDrink;
       tip = true;
		string listOfNotHere = "";
		string Extra = "";
        foreach (string ingredient in glass.contents)
        {
			if (!theDrink.ingredients.Contains(ingredient))
            {
                tip = false;
				Extra = Extra + ingredient + ", ";
            }
        }

		foreach (var ingredient in theDrink.ingredients)
		{
			if (!glass.contents.Contains(ingredient))
			{
				tip = false;
				listOfNotHere = listOfNotHere + ingredient + ", ";
			}
		}

        if (tip)
        {
			CorrectDrink.SetActive (true);
			NewOrder.GetComponent<DrinksArray> ().RandomOrder();
			Point += 1;
			Points.text = Point.ToString();
		}

        else
        {
			WrongDrink.SetActive (true);
			if (listOfNotHere != "") {
				WrongDrink.GetComponent<Text> ().text = WrongDrink.GetComponent<Text> ().text + "Missing ingredients " + listOfNotHere + " ";
			}

			if (Extra != "") {
				WrongDrink.GetComponent<Text> ().text = WrongDrink.GetComponent<Text> ().text + "Extra ingredients " + Extra;
			}
			NewOrder.GetComponent<DrinksArray> ().RandomOrder();
			if (CountDownTimer <= 0f) {
				Point -= 1;
				Points.text = Point.ToString();
				CountDownTimer = 20f;
			}
        }
        glass.Empty();
    }
}