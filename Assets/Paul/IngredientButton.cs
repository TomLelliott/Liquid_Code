using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientButton : MonoBehaviour
{
    void Awake()
    {
        // attach the button to the script for testing...
        Button button = GetComponent<Button>();
        Ingredient ingredient = GetComponent<Ingredient>();
        button.onClick.AddListener(() => ingredient.AddToGlass());
    }
}
