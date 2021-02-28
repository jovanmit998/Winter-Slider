using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ACHGlavnaScena : MonoBehaviour {
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
    public GameObject Poeni40JumpPoeniACH;
    public Toggle CheckBounce;
    public Toggle CheckPoeni10;
    public Toggle CheckPoeni80;
    public Toggle CheckPoeni40JumpPoeni;//Shawn nagrada
    public InputField Password;
    private bool Shawn=false;
    public GameObject kapa;
    public GameObject pingvin;
    public GameObject Query;
    public static bool ZidoviACH=false;
    public GameObject Sneg1;
    public GameObject Sneg2;
    public GameObject Sneg3;
    public GameObject PosebnaNagrada;
    void Start()
    {
       
    }


    void Update()
    {
       

        Sladoled();
        Odskok();
        Odbacivanje_Poeni();
        Poeni10();
        Poeni40();
        Poeni80();
        Poeni40JumpPoeni();
        CheckPolja();
        
    }
   
    void CheckPolja()
    {
        if (CheckPoeni10.isOn)
        {
            kapa.active = true;

        }
        else
        {
            kapa.active = false;
        }
        if (CheckPoeni40JumpPoeni.isOn)
        {
            pingvin.active = false;
            Query.active = true;

        }
        else
        {
            pingvin.active = true;
            Query.active = false;
        }
        if (CheckBounce.isOn)
        {
            ZidoviACH = true;

        }
        else
        {
            ZidoviACH = false;
        }
        if (CheckPoeni80.isOn)
        {
            Sneg1.active = true;
            Sneg2.active = true;
            Sneg3.active = true;
            PosebnaNagrada.active = true;

        }
        else
        {
            Sneg1.active = false;
            Sneg2.active = false;
            Sneg3.active = false;
            PosebnaNagrada.active = false;
        }

    }
    public void ShawnsMod()
    {
        if (Password.text=="imsorrygod")
            Shawn = true;

    }
    void Poeni40JumpPoeni()
    {
        if((slikaOdbacivanja_Poenipozitivno.active==true && slikaPoeni40pozitivno.active==true) || Shawn==true)
       {
            Poeni40JumpPoeniACH.active = true;


       }



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
        if (GlobalAch.Poeni_10_ACH == 1)
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
