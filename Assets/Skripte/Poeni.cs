using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poeni : MonoBehaviour {
    public static int poeni;
   
    
    
    private void Start()
    {

        poeni = 0;

    }
    private void OnTriggerEnter(Collider other)
    {
        poeni += 1;
        Debug.Log("Svaka cast");


       

    }


}

