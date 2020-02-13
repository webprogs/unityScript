using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    // basic animation
    Animator anim;
    void Start()
    {
	    anim =  GetComponent<Animator>();
    }

    void Update()
    {
    	if (Input.GetKey(KeyCode.W)) {
    		Debug.Log(0);
	        anim.SetInteger ("action", 1);
    	} else if (Input.GetKey(KeyCode.S)) {
	        anim.SetInteger ("action", 2);
    	} else {
	        anim.SetInteger ("action", 0);
    	}
    }
}
