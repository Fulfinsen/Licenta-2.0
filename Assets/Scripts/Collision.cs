using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You went over me!");
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("You left the area!");
    }
}
