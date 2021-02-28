using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kretanje : MonoBehaviour {
    /*
     * Skripta koja je povezana za igraca
     * Kao i odbacivanja i GUI za odbacivanja
     * Kao i racunanje odbacivanja
     * 
     * */
    public static float brzina=30.0f;
    public Rigidbody rb;
    public static float sila=120f;
    public static float Broj_Odbacivanja = 40f;
    public Slider Odbacivanja;
    public static int Odbacivanja_Achievement=0;
    public AudioSource pomeraj_zvuk;
    public AudioSource sleepy;
    public float BrojacZaSpavanje = 0f;
    public GameObject Query;
    public Button DugemLevo;
    public Button DugemDesno;
    void Start () {
        DugemLevo.onClick.AddListener(PomerajULevo);
        DugemDesno.onClick.AddListener(PomerajUDesno);
        Broj_Odbacivanja = 40f;
        rb = GetComponent<Rigidbody>();
        Odbacivanja.value = VratiBrOdbacivanja();
        Odbacivanja_Achievement = 0;
        sila = 120f;
       
    }
	
	void Update () {
        if (Triger.detekcija == false)
        {
            if (Broj_Odbacivanja > 0)
            { 
                Pomeraj();
            }
            Dodatak();
            Korekcija();
        }

        //Ispod ovoga je kod za jedan od zvukova
        if (Query.active == true)
        {
            BrojacZaSpavanje += Time.deltaTime;
        }
        SleepySound();
        
	}
    void SleepySound()
    {
        if(BrojacZaSpavanje>=4)
        {
            sleepy.Play();
        }

    }
    float VratiBrOdbacivanja()
    {

        return Broj_Odbacivanja / 40;
    }


    private void Pomeraj() {
        if (UIController_GlavnaScena.PocetniPanelActive == false)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rb.AddForce(0, 0, -sila);
                Broj_Odbacivanja -= 1;
                Odbacivanja.value = VratiBrOdbacivanja();
                Odbacivanja_Achievement++;
                pomeraj_zvuk.Play();
                BrojacZaSpavanje = 0;

            }

            // this.transform.Translate(0,0,-Input.GetAxis("Horizontal")*Time.deltaTime*brzina);
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.AddForce(0, 0, sila);
                Broj_Odbacivanja -= 1;
                Odbacivanja.value = VratiBrOdbacivanja();
                Odbacivanja_Achievement++;
                pomeraj_zvuk.Play();
                BrojacZaSpavanje = 0;

            }
        }

    }
    public void Korekcija() {

        if (this.transform.position.z > 16)
            this.transform.position = new Vector3(-35.3f, 1.92f, 12);
        if(this.transform.position.z<-16)
            this.transform.position = new Vector3(-35.3f, 1.92f, -11);

    }
    void Dodatak()
    {
        if (Sladoled_Triger.Provera == true)
        {
            if (RoadManager.Provera_Za_Animaciju == true)
            {
                if (GlobalAch.Sladoled_ACH == 1)
                {
                    Broj_Odbacivanja += 7;
                    Odbacivanja.value = VratiBrOdbacivanja();
                    Sladoled_Triger.Provera = false;
                }
                else
                {
                    Broj_Odbacivanja += 6;
                    Odbacivanja.value = VratiBrOdbacivanja();
                    Sladoled_Triger.Provera = false;
                }
            }
            else
            {
                if (GlobalAch.Sladoled_ACH == 1)
                {
                    Broj_Odbacivanja += 5;
                    Odbacivanja.value = VratiBrOdbacivanja();
                    Sladoled_Triger.Provera = false;
                }
                else
                {
                    Broj_Odbacivanja += 4;
                    Odbacivanja.value = VratiBrOdbacivanja();
                    Sladoled_Triger.Provera = false;

                }


            }

        }
    }

   void PomerajULevo()
    {
        rb.AddForce(0, 0, sila);
        Broj_Odbacivanja -= 1;
        Odbacivanja.value = VratiBrOdbacivanja();
        Odbacivanja_Achievement++;
        pomeraj_zvuk.Play();
        BrojacZaSpavanje = 0;


    }
    void PomerajUDesno()
    {
        rb.AddForce(0, 0, -sila);
        Broj_Odbacivanja -= 1;
        Odbacivanja.value = VratiBrOdbacivanja();
        Odbacivanja_Achievement++;
        pomeraj_zvuk.Play();
        BrojacZaSpavanje = 0;


    }







}
