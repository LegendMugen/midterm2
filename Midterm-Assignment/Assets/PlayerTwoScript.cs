using UnityEngine;
using UnityEngine.InputSystem;



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
