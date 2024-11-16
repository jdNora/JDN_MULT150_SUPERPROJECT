using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, transform.position + new Vector3(0, -2, i), transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
            Instantiate(prefab);
        if(Input.GetKeyUp(KeyCode.Space))
            Instantiate(prefab, transform.position, transform.rotation);
    }
}
