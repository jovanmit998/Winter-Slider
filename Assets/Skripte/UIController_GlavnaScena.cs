using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIController_GlavnaScena : MonoBehaviour {
    public GameObject Achievement;
    public GameObject DefaultPanel;
    public GameObject PocetakPanel;
    public GameObject Muzika;
    public Transform Podloga1;
    public Transform Podloga2;
    public Transform Podloga3;
    public Transform Igrac;
    public RoadManager skripta=new RoadManager();
    public Rigidbody Player;
    public Toggle checkbox;
    private bool Check = false;
    public AudioSource Click;
    public Toggle checkboxMuzika;
    public int HighScore;
    private int Pomocna;
    public TMP_Text HighScoreTxt;
    private bool pomocni=true;
    public AudioSource Hello;
    public AudioSource Eat;
    private bool EatPomoc = false;
    public static bool PocetniPanelActive=false;
    public AudioSource Youcandoit;
    public GameObject MuzikaAnime;
    public GameObject DugmeLevo;
    public GameObject DugmeDesno;

    private void Start()
    {
        Triger.BrojacSmrti = 0;
        EatPomoc = false;
        pomocni = true;
        HighScoreTxt.GetComponent<TMP_Text>();
        Player.GetComponent<Rigidbody>();
        Muzika.active = true;
            PocetniPanel();
        MuzikaAnime.active = true;
        
        
        DefaultPanel.active = false;
        Achievement.active = false;



    }
    private void Update()
    {
      
       
      
       
        if(Triger.detekcija2==true)
        {
            HighScoreFunct();
            DefaultPanel.active = true;
            Muzika.active = false;
            MuzikaAnime.active = false;
            Cursor.visible = true;
            DugmeLevo.active = false;
            DugmeDesno.active = false;
           
        }
        if (Sladoled_Triger.Provera == true && EatPomoc==false)
        {
            Eat.Play();
            EatPomoc = true;
        }




    }
    
   
        

    
    void HighScoreFunct()
    {
       HighScoreTxt.text = "HighScore: " + PlayerPrefs.GetInt("Highscore1");
       if(PlayerPrefs.GetInt("Highscore1")<Poeni.poeni)
       PlayerPrefs.SetInt("Highscore1", Poeni.poeni);
        

    }

       

    public void OtvoriACH()
    {
        Click.Play();
        
        Achievement.active = true;
        DefaultPanel.active = false;
        Triger.detekcija2 = false;

    }
    public void Back()
    {
        Achievement.active = false;
        DefaultPanel.active = true;
        Click.Play();


    }
    public void MainMenu()
    {
        DefaultPanel.active = false;
        Application.LoadLevel("Pocetna_scena");
        Click.Play();


    }
    public void TryAgain()
    {
        if (Triger.BrojacSmrti % 3 == 0)
        {
            Youcandoit.Play();
        }
        Click.Play();
       if (checkboxMuzika.isOn)
        {
            Muzika.active = false;
            MuzikaAnime.active = false;
       }
        else
        {
            Muzika.active = true;
            MuzikaAnime.active = true;
        }
        TransformIgracZid();
        ResetACH();
        Triger.detekcija = false;
        Time.timeScale = 1f;
        Triger.detekcija2 = false;
        DefaultPanel.active = false;
        if (Check == false)
        {
            PocetniPanel();
        }
        if (Check == true)
        {
            Cursor.visible = false;
        }
        EatPomoc = false;
        DugmeLevo.active = true;
        DugmeDesno.active = true;
    }
    public void PocetniPanel()
    {
        PocetakPanel.active = true;
        Time.timeScale = 0f;
        Muzika.active = false;
        PocetniPanelActive = true;
        MuzikaAnime.active = false;
        DugmeLevo.active = false;
        DugmeDesno.active = false;
    }
    public void Zapocni()
    {
        Click.Play();
        if (checkbox.isOn)
        {
            Check = true;

        }
        DefaultPanel.active = false;
        PocetakPanel.active = false;
        Time.timeScale = 1f;
        Cursor.visible = false;
        Hello.Play();
        PocetniPanelActive = false;
        if (!checkboxMuzika.isOn)
        {
            MuzikaAnime.active = true;
            Muzika.active = true;
        }
        DugmeLevo.active = true;
        DugmeDesno.active = true;
    }
    void TransformIgracZid()
    {
        Igrac.position = new Vector3(-33.97f, 1.92f, -0.14f);
        Podloga1.position = new Vector3(0.1f, 0, 0);
        Podloga2.position = new Vector3(68.1f, 0, 0);
        Podloga3.position = new Vector3(137.4f, 0, 0);

    }
    void ResetACH()
    {
        Player.velocity = Vector3.zero;
        Player.angularVelocity = Vector3.zero;
        skripta.TransformZida();
        Poeni.poeni = 0;
        Sladoled_Triger.BrojSladoleda = 0;
        Odbacivanja_Collide.Odbacivanja_Broj = 0;
        Kretanje.sila = 120f;
        RoadManager.brzina_podloge = 0.3f;
        RoadManager.Provera_Za_Animaciju = false;
        Kretanje.Broj_Odbacivanja = 40f;
        Kretanje.Odbacivanja_Achievement = 0;
    }
   
   


}
