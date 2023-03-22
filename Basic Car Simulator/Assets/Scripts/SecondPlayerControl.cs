using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerControl : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 25.0f;
    private float horzontalInput, verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Here we Take Player Input
        horzontalInput = Input.GetAxis("Horizontal2");
        verticalInput = Input.GetAxis("Vertical2");

        // This makes vehicle move forward or backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //  This makes Vehicle rotate left and right 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horzontalInput);
    }
}
