using UnityEngine;

public class Boundary : MonoBehaviour
{
    [SerializeField] ballControlScript ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame

    // If ball touches the outside boundaries, it resets it's position back to the middle.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ball.transform.position = ball.startPos;
        ball.launch();
    }
}
