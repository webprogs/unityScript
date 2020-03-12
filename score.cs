using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    Text txt;
    public GameObject myScore;
    
    void Start()
    {
        txt = myScore.GetComponent<Text>();
        txt.text = "Change Text";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
