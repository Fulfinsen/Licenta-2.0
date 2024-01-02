using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;


    bool hasPackage;
    [SerializeField] float delay = 1f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch!");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("The package was taken!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, delay);
        }
        if (collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("The package was delivered succesfully!");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {

    }
}
