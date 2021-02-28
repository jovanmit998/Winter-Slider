using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zakljucati_Kameru : MonoBehaviour {

    public Transform igrac;
   
    
	void Start () {
        this.transform.position = new Vector3(igrac.transform.position.x - 9f, 5.9f, igrac.transform.position.z);
    }
	
	
	void Update () {

        Kamera();


    }
    public void Kamera()
    {

        this.transform.position = new Vector3(igrac.transform.position.x - 9f, 5.9f, igrac.transform.position.z);

    }


}
