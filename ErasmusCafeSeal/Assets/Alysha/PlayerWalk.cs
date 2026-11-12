using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }
}
