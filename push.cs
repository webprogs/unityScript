using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s")) {
        	rb.AddForce(Vector3.forward * 500);
        }
    }
}
