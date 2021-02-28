using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odbacivanja_Collide : MonoBehaviour {
    public AudioSource odbacivanje_s;
    public static int Odbacivanja_Broj = 0;
    private void OnCollisionEnter(Collision collision)
    {
        Odbacivanja_Broj++;
        odbacivanje_s.Play();
        Debug.Log("Odbacivanje");

    }
    private void Start()
    {
        Odbacivanja_Broj = 0;
        
    }
}
