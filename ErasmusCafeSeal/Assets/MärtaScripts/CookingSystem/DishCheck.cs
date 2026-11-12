using Unity.VisualScripting;
using UnityEngine;

public class DishChecks : MonoBehaviour
{
    //Should run as ingredients have been mixed, check if correct recepie, set dish-sprite accordingly
    public bool isRecepie;

    public void Start()
    {

    }

    public void Update()
    {
        
    }

    private void isChecking()
    {
        //need scripting for bowl input, checks colliders?, for every "drop", check int of item, register to list.

        //WAIT FOR MIXING --> during/after mixing compare playerInputList with receipieList -->
        //should compare player input into bowl,, with recepies available, if right --> set isRecepie == true
        
        // if recepies dont match, isRecepie = false --> call for SLOP()
    }

}
