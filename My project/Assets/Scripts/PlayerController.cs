using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
    public float timeLeft;
    public bool isGrounded = true;
    public float speed = 1;
    private float lastChek = 1;

    [SerializeField] private GameObject losePanel;


    // Update is called once per frame
    void FixedUpdate()
    {
        speed = speed + Time.deltaTime / 100;
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        
        if (lastChek - transform.position.z == 0)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
        lastChek = transform.position.z;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 150, 0));
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



    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "obstacle")
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }





}
