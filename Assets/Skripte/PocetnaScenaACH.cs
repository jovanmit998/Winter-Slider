using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocetnaScenaACH : MonoBehaviour {
    public GameObject slikaSladoledpozitivno;
    public GameObject slikaSladolednegativno;
    public GameObject slikaOdbacivanja_Poenipozitivno;
    public GameObject slikaOdbacivanja_Poeninegativno;
    public GameObject slikaOdskokpozitivno;
    public GameObject slikaOdskoknegativno;
    public GameObject slikaPoeni10pozitivno;
    public GameObject slikaPoeni10negativno;
    public GameObject slikaPoeni40pozitivno;
    public GameObject slikaPoeni40negativno;
    public GameObject slikaPoeni80pozitivno;
    public GameObject slikaPoeni80negativno;

    void Start () {
		
	}
	
	
	void Update () {

        Sladoled();
        Odskok();
        Odbacivanje_Poeni();
        Poeni10();
        Poeni40();
        Poeni80();

	}
    void Sladoled()
    {
        if (GlobalAch.Sladoled_ACH == 1)
        {
            slikaSladolednegativno.active = false;
            slikaSladoledpozitivno.active = true;
        }

    }
    void Odskok()
    {
        if (GlobalAch.Odskok_ACH == 1)
        {
            slikaOdskoknegativno.active = false;
            slikaOdskokpozitivno.active = true;
        }

    }
    void Odbacivanje_Poeni()
    {
        if (GlobalAch.Poeni_Odbacivanja_ACH == 1)
        {
            slikaOdbacivanja_Poeninegativno.active = false;
            slikaOdbacivanja_Poenipozitivno.active = true;
        }


    }
    void Poeni10()
    {
        if(GlobalAch.Poeni_10_ACH==1)
        {
            slikaPoeni10negativno.active = false;
            slikaPoeni10pozitivno.active = true;


        }


    }
    void Poeni40()
    {
        if (GlobalAch.Poeni_50_ACH == 1)
        {
            slikaPoeni40negativno.active = false;
            slikaPoeni40pozitivno.active = true;


        }


    }
    void Poeni80()
    {
        if (GlobalAch.Poeni_100_ACH == 1)
        {
            slikaPoeni80negativno.active = false;
            slikaPoeni80pozitivno.active = true;


        }


    }



}
