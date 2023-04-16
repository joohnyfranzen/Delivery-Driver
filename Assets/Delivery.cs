using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32 (20, 20, 20, 20);
    bool hasPackage;

    SpriteRenderer spriteRenderer;
    void Start() {
        
    }
    void OnCollisionEnter2D(Collision2D other) {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D other) {

        if (other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("Package Picked!"); 
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor; 
        }    
        if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Deliveried");
            hasPackage = false;
            spriteRenderer.color = noPackageColor; 

        }
    }
}
