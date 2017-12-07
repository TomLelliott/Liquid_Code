using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{
    public List<string> contents = new List<string>();

    void Awake()
    {
        Empty();
    }

    public void AddIngredient(string ingredient)
    {
        contents.Add(ingredient);
    }

    public void Empty()
    {
        contents.Clear();
    }
}
