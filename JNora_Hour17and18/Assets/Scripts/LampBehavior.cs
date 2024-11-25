using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampBehavior : MonoBehaviour
{
    Animator lampAnimator;

    // Start is called before the first frame update
    void Start()
    {
        lampAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            lampAnimator.SetTrigger("Color");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            lampAnimator.SetTrigger("Scale");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            lampAnimator.SetTrigger("Spin");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            lampAnimator.SetTrigger("Hover");
        }
    }
}
