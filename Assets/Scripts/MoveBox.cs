using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    private Vector3 touchPosition;
    private Vector3 mousePos;
    public Rigidbody2D rb;
    private Vector3 direction;
    public float moveSpeed = 5f;
    bool MouseDOWN = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        MouseDOWN = true;
    }

    void OnMouseUp()
    {
        MouseDOWN = false;
    }


    void FixedUpdate()
    {
        if (MouseDOWN){
        {
         //   Touch touch = Input.GetTouch(0); 
         //   touchPosition = Camera.main.ScreenToWorldPoint(touch.position);  
         //   touchPosition.z = 0;   
         //    if (touch.phase == TouchPhase.Ended) rb.velocity = Vector2.zero;              
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            direction = (mousePos - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeed;
        }
    }
}
}

