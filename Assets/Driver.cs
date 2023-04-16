using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 20f;
    [SerializeField] float moveSpeed = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmout = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmout = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
         transform.Rotate(0, 0, -steerAmout);
         transform.Translate(0, -moveAmout, 0);
    }
}
