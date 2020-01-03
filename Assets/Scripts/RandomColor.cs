using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    // public Color[] colors;
    void Start()
    {
      //  GetComponent <SpriteRenderer>().color = colors[Random.Range(0, colors.Length)];
        Color colBox = new Color(Random.value,Random.value,Random.value);
        if (colBox.r == 186 && colBox.g == 213 && colBox.b == 255){
            GetComponent <SpriteRenderer>().color = new Color(186, 113,255, 1);
        } else {
            GetComponent <SpriteRenderer>().color = colBox;



            
    }

}
}