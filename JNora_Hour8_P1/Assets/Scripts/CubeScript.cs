using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.05f, 0f, 0f);
        transform.Rotate(0f, 0f, 1f);
        transform.localScale = new Vector3(2f, 2f, 2f);
    }
}