using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
            Instantiate(prefab);
        if(Input.GetKeyUp(KeyCode.Space))
            Instantiate(prefab, transform.position, transform.rotation);
    }
}
