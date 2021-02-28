using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueryAnimacija : MonoBehaviour {

    public Animation anim1;
   

    void Start()
    {


    }


    void Update()
    {

        PromeniAnimaciju();
       
    }
    public void PromeniAnimaciju()
    {
        if (RoadManager.Provera_Za_Animaciju == true)
        {
            anim1.Play("004_Run");
            
        }
        else
            anim1.Play("003_Walk");


    }


}
