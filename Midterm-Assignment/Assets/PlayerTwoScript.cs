using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;



public class PlayerTwoScript : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gives player two a variable
        float moveY = transform.position.y;

        if(Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            moveY += 5;
        }

        if(Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            moveY -= 5;
        }

        
    }
}
