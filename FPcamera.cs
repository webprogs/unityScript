using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPcamera : MonoBehaviour
{
 	// Start is called before the first frame update
    public float speedX = 2.0f;
    public float speedY = 2.0f;


    private float Horizontal = 0.0f;
    private float Vertical = 0.0f;
    
    // Update is called once per frame
    void Update()
    {
        Horizontal += speedX * Input.GetAxis("Mouse X");
        Vertical -= speedY * Input.GetAxis("Mouse Y");

        transform.eulerAngles =  new Vector3(Vertical, Horizontal, 0.0f);
    }
}
