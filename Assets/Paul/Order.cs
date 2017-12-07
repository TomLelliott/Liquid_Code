using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Order : MonoBehaviour
{
    Text text;
    public Drink current;
    public List<Drink> drinks = new List<Drink>();

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Start()
    {
        RandomOrder();
    }

    public void RandomOrder()
    {
        current = drinks[Random.Range(0, drinks.Count)];
        text.text = current.name;
    }
}
