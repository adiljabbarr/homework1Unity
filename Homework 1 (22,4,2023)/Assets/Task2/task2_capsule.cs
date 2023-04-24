using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2_capsule : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Capsule plane-ə toxunduqda meshi sönəcək və içindən keçəcək.
        //Plane - dən çıxdığı zaman isə Capsule obyektinin meshi yanacaq və tagı "Entered" olacaq.
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        
    }

    private void OnCollisionExit(Collision collision)
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;        
        gameObject.tag = "Entered";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
