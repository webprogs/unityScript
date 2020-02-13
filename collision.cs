using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void OnCollisionEnter (Collision col) {
    	if (col.gameObject.tag == "box") {
    		Destroy(col.gameObject);
    	}
    }
}
