using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour
{

    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 50f;



    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float steerAmountC = Input.GetAxis("HorizontalC") * steerSpeed * Time.deltaTime;
        float moveAmountC = Input.GetAxis("VerticalC") * moveSpeed * Time.deltaTime ;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, -steerAmountC);
        transform.Translate(0, moveAmountC, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
        //if (collision.tag == "Slow")
        //{
        //    moveSpeed = slowSpeed;
        //    collision.isTrigger = false;
        //}
    }
}