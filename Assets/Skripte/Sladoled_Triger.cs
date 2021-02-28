using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Sladoled_Triger : MonoBehaviour {
   
    public static bool Provera = false;
    public static int BrojSladoleda = 0;
    public AudioSource zvuk;
   
    private void OnTriggerEnter(Collider other)
    {
        Provera = true;
        BrojSladoleda++;
        zvuk.Play();
        
    }
    private void Start()
    {
        Provera = false;
        BrojSladoleda = 0;


    }
   



}
