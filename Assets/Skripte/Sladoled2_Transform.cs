using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sladoled2_Transform : MonoBehaviour {
    //Transformacija drugog sladoleda na mapi
    //Skripta se nalazi na objektu pod nazivom "Detekcija poena(1)"
    public GameObject sladoled;
    private void OnTriggerEnter(Collider other)
    {
        sladoled.transform.localPosition = new Vector3(Random.Range(0.5f, 5), 1.39f, Random.Range(-4.4f, 4.4f));




    }
    private void Start()
    {
        sladoled.transform.localPosition = new Vector3(Random.Range(0.5f, 5), 1.39f, Random.Range(-4.4f, 4.4f));
    }

}
