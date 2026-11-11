using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.uKey.isPressed)
        {
            transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
            Debug.Log("shejd");
        }
    }
}
