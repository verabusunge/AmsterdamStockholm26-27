using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    /*private void OnMouseEnter()
    {
        Debug.Log("jsje");
       SceneManager.LoadScene("Anton");
    }  */
 
        void StopGameee()
        {
            Application.Quit();
        }
    }


