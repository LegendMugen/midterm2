//using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.InputSystem;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using TMPro;
//using UnityEngine.SceneManagement;



public class PlayerTwoScript : MonoBehaviour
{
    public SpriteRenderer SR;

    public Rigidbody2D RB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if(Input.GetKey(KeyCode.UpArrow))
        //{


        //}
        //gives player two a variable
        float moveY = transform.position.y;
        float moveSpeed = 6;

        // Allows the player to move up
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

        }

        // Allows the player to move down

        if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);

        }
        

    }
}
