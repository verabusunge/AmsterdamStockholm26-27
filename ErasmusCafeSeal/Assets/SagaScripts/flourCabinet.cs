using UnityEngine;

public class flourCabinet : MonoBehaviour
{
       public GameObject ThingIWantToHide; // panel
        public void onClick() //n�r man klickar knappen
        {
            ThingIWantToHide.SetActive(false); //d� tar man bort panelen 
        }
}
