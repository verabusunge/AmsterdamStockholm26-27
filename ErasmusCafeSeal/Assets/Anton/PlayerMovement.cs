using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public bool IsGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.dKey.isPressed) //if D is pressed
        {
            transform.position += Vector3.right * speed * Time.deltaTime; //go right
        }
        if (Keyboard.current.aKey.isPressed) //if a is pressed
        {
            transform.position += Vector3.left * speed * Time.deltaTime; //go left
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame && IsGrounded == true)
        {
            transform.position += Vector3.up * speed * 100 * Time.deltaTime;
        }



        if (transform.position.y <= -10) //if y is under -10
        {
            Start(); //play the entie start void which is just respawn to start
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DF")) //if touching something with the tag "DF"
        {
            IsGrounded = true; //bool will be true
        }
        else //if its not colliding with something that has the tag
        {
            IsGrounded = false; //turns off the bool which makes it not able to jump
        }
    }
}
