using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player entered " + gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Player is inside " + gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Player exited " + gameObject.name);
    }
}
