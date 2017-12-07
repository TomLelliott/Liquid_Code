using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public Glass glass;

    public void AddToGlass()
    {
        glass.AddIngredient(name);
    }
}
