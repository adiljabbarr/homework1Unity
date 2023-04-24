using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class task1_script : MonoBehaviour
{
    void Start()
    {        
        GameObject.FindGameObjectWithTag("Changeable");
        gameObject.GetComponent<BoxCollider>().enabled = false;
        if (GameObject.FindGameObjectWithTag("Changeable"))
        {           
            gameObject.tag = "Changed";            
            gameObject.GetComponent<task1_script>().enabled = false;
        }      
    }
    void Update()
    {
        
    }
}
