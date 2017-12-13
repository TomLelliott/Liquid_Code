using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOrder : MonoBehaviour
{
    public Glass glass;
	bool tip=false;

    public void Check()
    {
		DrinksArray drinks = GetComponent <DrinksArray> ();
		string theDrink = drinks.theDrink;
       tip = true;
        foreach (string ingredient in glass.contents)
        {
			if (!theDrink.Contains(ingredient))
            {
                tip = false;
                Debug.LogFormat("Extra ingredient {0}!", ingredient);
            }
        }

//        foreach (string ingredient in order.current.ingredients)
//        {
//            if (!glass.contents.Contains(ingredient))
//            {
//                tip = false;
//                Debug.LogFormat("Missing ingredient {0}!", ingredient);
//            }
//        }

        if (tip)
        {
            Debug.Log("TIP!");
        }
        else
        {
            Debug.Log("No tip!");
        }
        glass.Empty();
    }
}
