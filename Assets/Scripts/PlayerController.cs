using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    // Start is called before the first frame 

    // Used to set references to components within
    // the same game object that we want to access.
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called before rendering a frame.
    // This is where most of our game code will go
    void Update()
    {

    }

    // FixedUpdate is called before any physics calculations
    // This is where all of our physics code will go
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement*speed);
    }


}
