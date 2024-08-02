using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    // void Start()
    // {

    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 200 * Time.deltaTime);
    }
}
