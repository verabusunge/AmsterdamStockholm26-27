using Assets.MärtaScripts;
using UnityEngine;

public class Recepies : MonoBehaviour
{
    //All recepies should be defined in here,, dishCheck should call and "check" here --> if correct
    Kladdkaka kladdkaka;
    void Start()
    {
        kladdkaka = new Kladdkaka();
    }
}
