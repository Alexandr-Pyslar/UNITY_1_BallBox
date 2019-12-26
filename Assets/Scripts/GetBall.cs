using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBall : MonoBehaviour
{
    public GameObject newball;

    public void CreateBall()
    {
        Instantiate(newball, new Vector3 (0, 6f, 0), Quaternion.identity);
    }
    void Update()
    {       
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
