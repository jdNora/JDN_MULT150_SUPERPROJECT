using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");
        if(hVal != 0)
            print("Horizontal movement selected: " + hVal);
        if (vVal != 0)
            print("Vertical movement selected: " + vVal);

        if (Input.GetKey(KeyCode.M))
            print("The 'M' key is pressed down.");
        if (Input.GetKeyDown(KeyCode.O))
            print("The 'O' key was pressed.");

        float xVal = Input.GetAxis("Mouse X");
        float yVal = Input.GetAxis("Mouse Y");
        if (xVal != 0)
            print("Mouse X movement selected: " + xVal);
        if (yVal != 0)
            print("Mouse Y movement selected: " + yVal);
    }
}
