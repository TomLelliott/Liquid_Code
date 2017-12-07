using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlassContents : MonoBehaviour
{
    public Glass glass;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = string.Join(" + ", glass.contents.ToArray());
    }
}
