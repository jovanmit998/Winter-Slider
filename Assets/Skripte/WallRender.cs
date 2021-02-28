using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRender : MonoBehaviour {
    
    
    //Ove zidovi se pojavljuju
    public Renderer wall1;
    public Renderer wall2;
    public Renderer wall3;
    public Renderer wall4;
    public Renderer wall5;
    public Renderer wall6;
    //Ovi nestaju
    public Renderer zid1;
    public Renderer zid2;
    public Renderer zid3;
    public Renderer zid4;
    public Renderer zid5;
    public Renderer zid6;


    void Start () {
        wall1.GetComponent<Renderer>();
        wall2.GetComponent<Renderer>();
        wall3.GetComponent<Renderer>();
        wall4.GetComponent<Renderer>();
        wall5.GetComponent<Renderer>();
        wall6.GetComponent<Renderer>();

        zid1.GetComponent<Renderer>();
       zid2.GetComponent<Renderer>();
       zid3.GetComponent<Renderer>();
        zid4.GetComponent<Renderer>();
        zid5.GetComponent<Renderer>();
       zid6.GetComponent<Renderer>();



    }
	
	
	void Update () {
        PrikaziZidove();
	}
    void PrikaziZidove()
    {


        if (ACHGlavnaScena.ZidoviACH == true)
        {
            wall1.enabled = true;
            wall2.enabled = true;
            wall3.enabled = true;
            wall4.enabled = true;
            wall5.enabled = true;
            wall6.enabled = true;

            zid1.enabled = false;
            zid2.enabled = false;
            zid3.enabled = false;
            zid4.enabled = false;
            zid5.enabled = false;
            zid6.enabled = false;
        }
        else
        {
            wall1.enabled = false;
            wall2.enabled = false;
            wall3.enabled = false;
            wall4.enabled = false;
            wall5.enabled = false;
            wall6.enabled = false;

            zid1.enabled = true;
            zid2.enabled = true;
            zid3.enabled = true;
            zid4.enabled = true;
            zid5.enabled = true;
            zid6.enabled = true;


        }


       


    }
}
