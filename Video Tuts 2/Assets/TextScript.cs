using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextScript : MonoBehaviour
{
    public TextMeshPro Text;

    // Start is called before the first frame update
    void Start()
    {
        Text = FindObjectOfType<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "AFZAAL";
    }
}
