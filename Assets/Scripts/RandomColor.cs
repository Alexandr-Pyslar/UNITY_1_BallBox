using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public Color[] colors;
    void Start()
    {
        GetComponent <SpriteRenderer>().color = colors[Random.Range(0, colors.Length)];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
