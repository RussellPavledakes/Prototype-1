using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // public variables
    public float speed = 20.0f;
    public float trunspeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // we'll move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // we trun the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * trunspeed * horizontalInput);
    }
}
