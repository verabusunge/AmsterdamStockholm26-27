using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Sprites;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public bool IsGrounded;
    public float jumpForce = 5;
    public Rigidbody2D rb;
    public Animator playerAnim;
    bool isWalking;
    bool isJumping;
    bool facingLeft = true;
    bool facingRight = false;
    public GameObject playerSprite;
    // public float jumpSpeed = 100f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (isJumping == false && isWalking == false)
        {
            playerAnim.SetTrigger("Idle");
            print("idling");
        }
       
        if (isJumping == true)
        {
            playerAnim.SetTrigger("Jump");
            print("jumping");
        }
        if (Keyboard.current.dKey.isPressed) //if D is pressed
        {
            transform.position += Vector3.right * speed * Time.deltaTime; //go right
            isWalking = true;
            print("walking");
            if (isJumping == false)
            {
                playerAnim.SetTrigger("Walk");
            }
            else
            {
                isWalking = false;
            }
            if (facingLeft == true)
            {
                Vector3 currentScale = playerSprite.transform.localScale;
                currentScale.x = 1f;
                transform.localScale = currentScale;
            }


        }
        if (Keyboard.current.aKey.isPressed) //if a is pressed
        {
            facingLeft = true;
            transform.position += Vector3.left * speed * Time.deltaTime; //go left
            isWalking = true;
            print("walking");
            if (isJumping == false)
            {
                playerAnim.SetTrigger("Walk");
            }
            if (facingRight == true)
            {
                Vector3 currentScale = playerSprite.transform.localScale;
                currentScale.x = -1f;
                transform.localScale = currentScale;
            }
        }
        else
        {
            isWalking = false;
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
        isJumping = true;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) //if touching something with the tag "DF"
        {
            IsGrounded = true; //bool will be true
            print("COLLISION");
            isJumping = false;
        }
       
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = false;
            print("No collision");
        }
    }
}
