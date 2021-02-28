using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sladoled3_Transform : MonoBehaviour {
    //Transformacija treceg sladoleda na mapi
    //Skripta se nalazi na objektu pod nazivom "Detekcija poena(2)"
    public GameObject sladoled;
    
   
    private void OnTriggerEnter(Collider other)
    {
        sladoled.transform.localPosition = new Vector3(Random.Range(-0.2f, 4), 1.39f, Random.Range(-4.4f, 4.4f));
        



    }
    private void Start()
    {
        sladoled.transform.localPosition = new Vector3(Random.Range(-0.2f, 4), 1.39f, Random.Range(-4.4f, 4.4f));
       

    }
}
