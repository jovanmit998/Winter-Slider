using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Achievements : MonoBehaviour
{
    //U ovoj skripti se nalazi cela funkcionalnost vezana za Achievemente 
    //koje postizete tokom igre
    //Takodje se nalazi GUI
   
    public Text Tekst_Poeni;
    public TMP_Text Sladoled_TekstACH;
    public TMP_Text Poeni10_TekstACH;
    public TMP_Text Poeni50_TekstACH;
    public TMP_Text Poeni100_TekstACH;
    public TMP_Text Odskok_TekstACH;
    public TMP_Text Poeni_Odskok_TekstACH;
    public AudioSource Congratz;
    public AudioSource AchievementSound;



    void Start()
    {
        Sladoled_TekstACH.GetComponent<TMP_Text>();
        Poeni10_TekstACH.GetComponent<TMP_Text>();
        Poeni50_TekstACH.GetComponent<TMP_Text>();
        Poeni100_TekstACH.GetComponent<TMP_Text>();
        Odskok_TekstACH.GetComponent<TMP_Text>();
        Poeni_Odskok_TekstACH.GetComponent<TMP_Text>();
       
       


    }


    void Update()
    {
        
        Tekst_Poeni.text = "Points:" + " " + Poeni.poeni;
        SladoledACH();
        OdskokACH();
        PoeniACH();
        Poeni_OdbacivanjaACH();
        PrikaziOdskok_Text();
        PrikaziSladoledACH_Text();
        PrikaziPoene_Text();
        PrikaziPoeni_Odbacivanja_Text();

    }

    void SladoledACH()
    {
        if (Sladoled_Triger.BrojSladoleda >= 15 && GlobalAch.Sladoled_ACH != 1)
        {
            GlobalAch.Sladoled_ACH = 1;
            Congratz.Play();
            AchievementSound.Play();
            PlayerPrefs.SetInt("Achievements_Sladoled1", 1);
        }


    }


    void PoeniACH()
    {
        if (Poeni.poeni >= 10 && GlobalAch.Poeni_10_ACH != 1)
        {
            GlobalAch.Poeni_10_ACH = 1;
            Congratz.Play();
            AchievementSound.Play();
            PlayerPrefs.SetInt("Achievements_Poeni10", 1);

        }
        if (Poeni.poeni >= 20 && GlobalAch.Poeni_50_ACH != 1)
        {
            GlobalAch.Poeni_50_ACH = 1;
            Congratz.Play();
            AchievementSound.Play();
            PlayerPrefs.SetInt("Achievements_Poeni30", 1);

        }
        if (Poeni.poeni >= 45 && GlobalAch.Poeni_100_ACH !=1)
        {
            GlobalAch.Poeni_100_ACH = 1;
            Congratz.Play();
            AchievementSound.Play();
            PlayerPrefs.SetInt("Achievements_Poeni60", 1);
        }



    }
    void OdskokACH()
    {
        if (Odbacivanja_Collide.Odbacivanja_Broj >= 20 && GlobalAch.Odskok_ACH != 1)
        {
            GlobalAch.Odskok_ACH = 1;
            Congratz.Play();
            AchievementSound.Play();
            PlayerPrefs.SetInt("Achievements_Odskok", 1);

        }


    }
    void Poeni_OdbacivanjaACH()
    {
        if (Kretanje.Odbacivanja_Achievement <= 20 && Poeni.poeni >= 20 && GlobalAch.Poeni_Odbacivanja_ACH != 1)
        {

            GlobalAch.Poeni_Odbacivanja_ACH = 1;
            Congratz.Play();
            AchievementSound.Play();
            PlayerPrefs.SetInt("Achievements_PoeniOdbacivanja", 1);

        }


    }


    //Ispod su metode za ispis teksta o uspesno izvrsenom achievementu
    void PrikaziSladoledACH_Text()
    {
        if (GlobalAch.Sladoled_ACH == 1 && GlobalAch.sladoled_brojac <= 4)
        {
            Odskok_TekstACH.text = "";
            Poeni10_TekstACH.text = "";
            Poeni50_TekstACH.text = "";
            Poeni100_TekstACH.text = "";
            Poeni_Odskok_TekstACH.text = "";

            Sladoled_TekstACH.text = "Congratulations you\nhave completed\nice cream achievement";
            GlobalAch.sladoled_brojac += Time.deltaTime * 2;
        }
        else
        {
            Sladoled_TekstACH.text = "";


        }



    }
    void PrikaziOdskok_Text()
    {
        if (GlobalAch.Odskok_ACH == 1 && GlobalAch.Odskok_brojac <= 4)
        {
            Sladoled_TekstACH.text = "";
            Poeni10_TekstACH.text = "";
            Poeni50_TekstACH.text = "";
            Poeni100_TekstACH.text = "";
            Poeni_Odskok_TekstACH.text = "";
            Odskok_TekstACH.text = "Congratulations you\nhave completed\nBounce achievement";
            GlobalAch.Odskok_brojac += Time.deltaTime * 2;
        }
        else
        {
            Odskok_TekstACH.text = "";


        }



    }
    void PrikaziPoene_Text()
    {
        //Poeni 10 txt
        if (GlobalAch.Poeni_10_ACH == 1 && GlobalAch.Poeni10_brojac <= 4)
        {
            Sladoled_TekstACH.text = "";
            Odskok_TekstACH.text = "";
            Poeni_Odskok_TekstACH.text = "";
            Poeni10_TekstACH.text = "Congratulations you\nhave completed\nPoints(10) achievement";
            GlobalAch.Poeni10_brojac += Time.deltaTime * 2;
        }
        else
        {
            Poeni10_TekstACH.text = "";


        }

        //Poeni 30 txt

        if (GlobalAch.Poeni_50_ACH == 1 && GlobalAch.Poeni50_brojac <= 4)
        {
            Sladoled_TekstACH.text = "";
            Odskok_TekstACH.text = "";
            Poeni_Odskok_TekstACH.text = "";
            Poeni50_TekstACH.text = "Congratulations you\nhave completed\nPoints(20) achievement";
            GlobalAch.Poeni50_brojac += Time.deltaTime * 2;
        }
        else
        {
            Poeni50_TekstACH.text = "";


        }
        //Poeni 60 txt
        if (GlobalAch.Poeni_100_ACH == 1 && GlobalAch.Poeni100_brojac <= 4)
        {
            Sladoled_TekstACH.text = "";
            Odskok_TekstACH.text = "";
            Poeni_Odskok_TekstACH.text = "";

            Poeni100_TekstACH.text = "Congratulations you\nhave completed\nPoints(45) achievement";
            GlobalAch.Poeni100_brojac += Time.deltaTime * 2;
        }
        else
        {
            Poeni100_TekstACH.text = "";


        }







    }
    void PrikaziPoeni_Odbacivanja_Text()
    {
        if (GlobalAch.Poeni_Odbacivanja_ACH == 1 && GlobalAch.Poeni_Odskok_brojac <= 4)
        {
            Sladoled_TekstACH.text = "";
            Poeni10_TekstACH.text = "";
            Poeni50_TekstACH.text = "";
            Poeni100_TekstACH.text = "";
            Odskok_TekstACH.text = "";
            Poeni_Odskok_TekstACH.text = "Congratulations you\nhave completed\nPoints-Bounce achievement";
            GlobalAch.Poeni_Odskok_brojac += Time.deltaTime * 2;
        }
        else
        {
            Poeni_Odskok_TekstACH.text = "";


        }


    }
   





}
