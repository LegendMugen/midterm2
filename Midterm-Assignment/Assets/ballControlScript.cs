//using System;
using UnityEngine;
using UnityEngine.InputSystem;
//using System.Collections;
//using System.Collections.Generic;


public class ballControlScript : MonoBehaviour
{
    float speed = 5;
    public Vector2 startPos;

    public Rigidbody2D RB;

    public SpriteRenderer SR;

    //public float speed;
    
    //public float startingSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        RB = GetComponent<Rigidbody2D>();
        launch();

        //RB = GetComponent<Rigidbody2D>();

        //RB = GetComponent<Rigidbody2D>();

        //bool isRight = UnityEngine.Random.value > 0.5;
        //float xVelocity = -1f;

        //if(isRight == true)
        //{
        //    xVelocity = 1f;
        //}

        //float yVelocity = UnityEngine.Random.Range(-1, 1);


        //rb.linearVelocity = new Vector2(xVelocity, yVelocity);
    }

    // Update is called once per frame
    public void launch()
    {
        int x = Random.Range(0, 2);
        int y = Random.Range(0, 2);

        if( x == 0)
        {
            x = -1;
        }

        if(y == 0)
        {
            y = -1;
        }

        RB.linearVelocity = new Vector2(x * speed, y * speed);
    }

   




        //int ballMoveX = 5;

        //int ballMoveY = 5;
        //Boolean constantMovement = false;

        //RB.AddForce(Vector2.right);
        //RB.AddForce(Vector2.left);


        //if (Keyboard.current.spaceKey.isPressed)
        //{
        //    constantMovement = !constantMovement;
        //}

        //if (constantMovement)
        //{
        //    transform.Translate(Vector2.right * Time.deltaTime);
        //}



    }

