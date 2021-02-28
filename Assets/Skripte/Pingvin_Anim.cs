using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pingvin_Anim : MonoBehaviour {
    public Animation anim1;
    
    
	void Start () {
        
        
    }
	
	
	void Update () {
        
        PromeniAnimaciju();
       
	}
    public void PromeniAnimaciju() {
        if (RoadManager.Provera_Za_Animaciju == true)
        {
            anim1.Play("run");
        }
        else
            anim1.Play("walk");
        

    }
   

}
