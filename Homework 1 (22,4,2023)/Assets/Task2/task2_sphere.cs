using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2_sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Sphere plane-ə toxunduğunda Sphere obyektinin adı "Empty" olacaq və plane-in üzərində qalacaq. Parenti isə plane obyekti olacaq. 
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.name = "Empty";
        gameObject.transform.parent = collision.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
