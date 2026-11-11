using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public bool IsGrounded;
   // public float jumpSpeed = 100f;
    public float jumpForce = 5;
    public Rigidbody2D rb;

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

        /* if (Keyboard.current.spaceKey.wasPressedThisFrame && IsGrounded == true)
         {
             transform.position += Vector3.up * jumpSpeed * Time.deltaTime;
         }*/

        if (Keyboard.current.spaceKey.wasPressedThisFrame && IsGrounded == true)// Om vi tycker på space, så låt spelaren hoppa
        {
            Jump();
        }


        if (transform.position.y <= -10) //if y is under -10
        {
            Start(); //play the entie start void which is just respawn to start
        }
    }
    private void Jump()
    {
        rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); // Lägg till vertical force för att kunna hoppa
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DF")) //if touching something with the tag "DF"
        {
            IsGrounded = true; //bool will be true
            print("COLLISION");
        }
       
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("DF"))
        {
            IsGrounded = false;
            print("No collision");
        }
    }
}
