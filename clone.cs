using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject original;
    void Start()
    {
        	for (int i = 0; i < 5; i++) {
        		GameObject Cloner = Instantiate(original, new Vector3(i, original.transform.position.y, i * 10f), original.transform.rotation);
        	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
