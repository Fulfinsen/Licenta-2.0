using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
}
