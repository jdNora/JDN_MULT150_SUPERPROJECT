using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int bounceCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        bounceCount++;
        Debug.Log(bounceCount);
    }
}
