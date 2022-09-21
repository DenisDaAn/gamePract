using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
    public float timeLeft;
    public bool isGrounded = true;


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, 1 * Time.deltaTime);

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 100, 0));
            timeLeft = 0.5f;
            
        }
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            isGrounded = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Vector3.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += Vector3.left * Time.deltaTime;





    }

    
    



    

}
