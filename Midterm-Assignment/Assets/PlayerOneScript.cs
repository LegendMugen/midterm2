using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerOneScript : MonoBehaviour
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
        float yPosition = transform.position.y;
        float yTravelSpeed = 6;

        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector2.up * yTravelSpeed * Time.deltaTime);

        }

        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector2.down * yTravelSpeed * Time.deltaTime);

        }

    }
}
