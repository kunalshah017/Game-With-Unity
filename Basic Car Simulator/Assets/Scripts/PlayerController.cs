using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horzontalInput, verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Here we Take Player Input
        horzontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // This makes vehicle move forward or backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //  This makes Vehicle rotate left and right 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horzontalInput);
    }
}
