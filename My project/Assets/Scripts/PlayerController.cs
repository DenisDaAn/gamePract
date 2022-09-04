using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public CharacterController controller;
    //public Vector3 dir;


    // Start is called before the first frame update
    void Start()
    {
        //controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, 1);
        //controller.Move(dir * Time.fixedDeltaTime);
    }
}
