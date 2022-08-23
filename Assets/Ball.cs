using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public bool gameStart = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameStart == false)
        {
            transform.SetParent(null);
            rb.AddForce(new Vector2(speed, speed));
            gameStart = true;
        }
    }

    
}
