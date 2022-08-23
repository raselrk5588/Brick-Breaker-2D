using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleForBall : MonoBehaviour
{
    public Rigidbody2D Paddle;
    public float MoveSpeed;

    public float miniX = -290f;
    public float maxX = 290f;

    Vector3 position;

    void Start()
    {

        Paddle = GetComponent<Rigidbody2D>();
        transform.position = Paddle.position;
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * MoveSpeed * Time.fixedDeltaTime;
        position.x = Mathf.Clamp(position.x, miniX, maxX);
        transform.position = position;
        MoveMent();
    }

    public void MoveLeft()
    {
        Paddle.velocity = new Vector2(-MoveSpeed, 0);
    }
    public void MoveRight()
    {
        Paddle.velocity = new Vector2(MoveSpeed, 0);
    }
    public void NotMove()
    {
        Paddle.velocity = Vector2.zero;
    }

    public void MoveMent()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float midle = Screen.width / 2;
            if (touch.position.x < midle && touch.phase == TouchPhase.Began)
            {
                MoveLeft();
            }
            else if (touch.position.x > midle && touch.phase == TouchPhase.Began)
            {
                MoveRight();
            }
            else
            {
                NotMove();
            }
        }
    }
}
