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
			
	}

	public void Check()
    {
		DrinksArray drinks = GetComponent <DrinksArray> ();
		Drink theDrink = drinks.theDrink;
       tip = true;
        foreach (string ingredient in glass.contents)
        {
			if (!theDrink.ingredients.Contains(ingredient))
            {
                tip = false;
				Debug.LogFormat("Extra ingredient {0} in the glass!", ingredient);
            }
        }

		foreach (var ingredient in theDrink.ingredients)
		{
			if (!glass.contents.Contains(ingredient))
			{
				tip = false;
				Debug.LogFormat("Missing ingredient {0} in the glass!", ingredient);
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
			NewOrder.GetComponent<DrinksArray> ().RandomOrder();
        }
        glass.Empty();
    }
}