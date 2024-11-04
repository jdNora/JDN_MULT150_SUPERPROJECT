using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoTriggerScript : MonoBehaviour
{
    Light cubeLight;

    // Start is called before the first frame update
    void Start()
    {
        cubeLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        cubeLight.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        cubeLight.enabled = false;
    }
}
