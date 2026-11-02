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
        int ballMoveX = 5;
        int ballMoveY = 5;
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            transform.Translate(Vector2.right *ballMoveX * Time.deltaTime);
            transform.Translate(Vector2.up *ballMoveY* Time.deltaTime);
        }
        
    }
}
