using UnityEngine;
using UnityEngine.InputSystem;
 public class StopGame : MonoBehaviour
{
          public void stopTheGame()
          {

            if (Keyboard.current.escapeKey.isPressed);
            {
               Application.Quit();
               Debug.Log("Stop the game");
            }
       
          }
}
