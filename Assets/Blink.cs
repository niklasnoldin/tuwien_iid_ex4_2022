using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Time.fixedTime%10<5)
        {
            GetComponent<Renderer>().enabled=false;
        }
        else{
            GetComponent<Renderer>().enabled=true;
        }
    }
}
