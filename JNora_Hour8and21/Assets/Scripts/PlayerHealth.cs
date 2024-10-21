using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthPoints = 3992;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(healthPoints);
        healthPoints = UsePotion(healthPoints);
        healthPoints = UsePotion(healthPoints);
        healthPoints = UsePotion(healthPoints);
        healthPoints = UsePotion(healthPoints);
        Debug.Log(healthPoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int UsePotion(int health)
    {
        return health + 400;
    }
}
