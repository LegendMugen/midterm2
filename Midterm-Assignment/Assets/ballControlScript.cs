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
        
    }

    // Update is called once per frame
    void Update()
    {
        //int ballMoveX = 5;

        //int ballMoveY = 5;
        Boolean constantMovement = false;

        if(Keyboard.current.spaceKey.isPressed)
        {
            constantMovement = !constantMovement;
        }

        if(constantMovement)
        {
            transform.Translate(Vector2.right *  Time.deltaTime);
        }

       
        
    }
}
