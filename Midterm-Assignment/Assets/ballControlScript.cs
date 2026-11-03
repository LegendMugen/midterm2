using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ballControlScript : MonoBehaviour
{

    public Rigidbody2D RB;

    public SpriteRenderer SR;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        RB = GetComponent<Rigidbody2D>();
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
    void Update()
    {


        bool isRight = UnityEngine.Random.value > 0.5;
        float xVelocity = -1f;

        if (isRight == true)
        {
            xVelocity = 1f;
        }

        float yVelocity = UnityEngine.Random.Range(-1, 1);


        RB.linearVelocity = new Vector2(xVelocity, yVelocity);




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
}
