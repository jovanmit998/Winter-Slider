using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triger : MonoBehaviour {

    public static bool detekcija = false;
    public static bool detekcija2 = false;
    public static int BrojacSmrti = 0;
    public AudioSource Sorry;
    public GameObject QueryChan;
    private void Start()
    {
        detekcija = false;
        detekcija2 = false;
    }

    private void OnTriggerEnter(Collider other)
    {
       detekcija2 = true;
          detekcija = true;
           Time.timeScale = 0f;
            Debug.Log("Bravo majmune");
        if (QueryChan.active == true)
        {
            BrojacSmrti++;
        }
        Sorry.Play();
    }
    


}
