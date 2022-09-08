using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool tap, swipeLeft, swipeRight, swipeUp, swipeDown;
    private bool isDraging = false;
    private Vector2 startTouch, swipeDelta;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, 1 * Time.deltaTime);
        while(Input.GetKeyDown(KeyCode.RightArrow) == true)
        {
            transform.position += Vector3.right * Time.deltaTime;
        }
        while (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }
    }
}
