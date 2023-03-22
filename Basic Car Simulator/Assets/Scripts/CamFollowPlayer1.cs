using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer1 : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0f, 10f, -20f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;

    }
}
