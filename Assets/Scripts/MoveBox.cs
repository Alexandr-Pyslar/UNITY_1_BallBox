using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    bool MouseDOWN = false;


    void OnMouseDown(){
      MouseDOWN = true;
    }

    void OnMouseUp(){
      MouseDOWN = false;
    }


    void Update()
    {
      Vector3 Cursor = Input.mousePosition;
      Cursor = Camera.main.ScreenToWorldPoint(Cursor);
      Cursor.z = 0;
          if (Cursor.x < -1.48f ){
          Cursor.x = -1.48f;
          }
          if (Cursor.x > 1.48f ){
          Cursor.x = 1.48f;
          }
          if (Cursor.y < -3.85f ){
          Cursor.y = -3.85f;
          }
          if (Cursor.y > 3.85f ){
          Cursor.y = 3.85f;
          }
      if (MouseDOWN){
        this.transform.position = Cursor;

      }
      
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }

    }
}
