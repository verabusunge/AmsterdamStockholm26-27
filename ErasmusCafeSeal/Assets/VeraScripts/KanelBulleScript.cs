using UnityEngine;

public class KanelBulleScript : MonoBehaviour
{
    public int ingredientsRequired;
    private int currentIngredients;
    private int kanelbulleProfit = 45;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentIngredients < ingredientsRequired)
        {
            print("not completed");
        }
    }


}
