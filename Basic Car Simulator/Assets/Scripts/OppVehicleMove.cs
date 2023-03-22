using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppVehicleMove : MonoBehaviour

{
    public float oppVehicleSpeed = 25f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * oppVehicleSpeed);
    }
}
