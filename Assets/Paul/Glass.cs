﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{
    public List<string> contents = new List<string>();
	public CheckOrder Manager;

    void Awake()
    {
        Empty();
    }

    public void AddIngredient(string ingredient)
    {
		if (!contents.Contains(ingredient)) {
			contents.Add(ingredient);
		}
       
    }

    public void Empty()
    {
        contents.Clear();
    }

	void OnTriggerEnter(Collider col){
		if(col.gameObject.CompareTag("Liquid")){
			AddIngredient (DrinksArray.currentBottle);
		}
		if(col.gameObject.CompareTag("Beer")){
			AddIngredient ("Beer");
		}
	}
}
