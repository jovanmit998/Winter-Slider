using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sladoled1_Transform : MonoBehaviour {
    //Transformacija prvog sladoleda na mapi
    //Skripta se nalazi na objektu pod nazivom "Detekcija poena"
    public GameObject sladoled;
    private void OnTriggerEnter(Collider other)
    {
        sladoled.transform.localPosition = new Vector3(Random.Range(0.6f, 6), 1.39f, Random.Range(-4.4f, 4.4f));




    }
    private void Start()
    {
        sladoled.transform.localPosition = new Vector3(Random.Range(0.6f, 6), 1.39f, Random.Range(-4.4f, 4.4f));


    }

}
