using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour {
    /*
     * RoadManager je skripta koja upravlja pomeranjem celog puta
     * Kao i promenom brzine pomeranja igraca
     * */
    public GameObject[] segmenti;
    public static float brzina_podloge=0.3f;
    float velicinasegmenta = 165f;
    
    public static bool Provera_Za_Animaciju=false;
    public GameObject zid1;
    public GameObject zid2;
    public GameObject zid3;
    public GameObject zid4;
    public GameObject zid5;
    public GameObject zid6;
    public GameObject Panel;
   
    
    void Start () {
        TransformZida();
        brzina_podloge = 0.3f;
        Provera_Za_Animaciju = false;
        
        
    }
	
	
	void Update () {
        if (Panel.active == false)
        {
            if (Triger.detekcija == false)
                Pomeranje();
        }
        PrvaBrzina();
       
       

	}
    //Pomeranje podloge
    private void Pomeranje() {
        for (int i = 0; i < segmenti.Length; i++)
        {
            float x = segmenti[i].transform.position.x;
            x -= brzina_podloge;
            x = Mathf.Round(x * 170) / 170;
            segmenti[i].transform.position = new Vector3(x, 0, 0);
            if (segmenti[i].transform.position.x <= -velicinasegmenta)
            {
                segmenti[i].transform.position = new Vector3(40, 0, 0);

                TransformZida();
                

                if (brzina_podloge < 0.7f)
                {
                    brzina_podloge += 0.03f;
                }
            }

        }


    }
    public void TransformZida() {
        //PRVA DVA ZIDA U NIZU
        zid1.transform.localScale = new Vector3(0.1458698f, 10, Random.Range(2.5f, 3.9f));//PRVI ZID
        zid2.transform.localScale = new Vector3(0.14587f, 10, Random.Range(2.5f, 3.9f));//DRUGI ZID
        if(zid1.transform.localScale.z>4.5f)
            zid2.transform.localScale = new Vector3(0.14587f, 10, Random.Range(2.5f, 4f));

        zid1.transform.localPosition=new Vector3(-1.566846f, 5.11f, Random.Range(3.1f, 1.3f));//PRVI ZID
        zid2.transform.localPosition=new Vector3(-1.08f, 5.11f, Random.Range(-3.1f, -1.3f));//DRUGI ZID

        //DRUGA DVA ZIDA U NIZU
        zid3.transform.localScale = new Vector3(0.1458698f, 10, Random.Range(2.5f, 3.9f));//TRECI ZID
        zid4.transform.localScale = new Vector3(0.14587f, 10, Random.Range(2.5f, 3.9f));//CETVRTI ZID
        if(zid3.transform.localScale.z>4.5f)
            zid4.transform.localScale = new Vector3(0.14587f, 10, Random.Range(2.5f, 4f));

        zid3.transform.localPosition = new Vector3(-1.932845f, 5.11f, Random.Range(3.1f, 1.5f));//TRECI ZID
        zid4.transform.localPosition = new Vector3(-1.5f, 5.11f, Random.Range(-3.1f, -1.5f));//CETVRTI ZID

        //TRECA DVA ZIDA U NIZU
        zid5.transform.localScale = new Vector3(0.1458698f, 10, Random.Range(2.5f, 3.9f));//PETI ZID
        zid6.transform.localScale = new Vector3(0.14587f, 10, Random.Range(2.5f, 3.9f));//SESTI ZID
        if (zid5.transform.localScale.z > 4.5f)
            zid6.transform.localScale = new Vector3(0.14587f, 10, Random.Range(2.5f, 4f));


        zid5.transform.localPosition = new Vector3(-2.85f, 5.11f, Random.Range(3.1f, 1.5f));//PETI ZID
        zid6.transform.localPosition = new Vector3(-2.39f, 5.11f, Random.Range(-3.1f, -1.5f));//SESTI ZID

    }
    //Funkcija koja povecava brzinu pomeranja karaktera pri vecoj brzini pomeranja podloge
    public void PrvaBrzina() {
        if (brzina_podloge > 0.5f)
            Kretanje.sila = 150f;
      

       //Promena animacija
        if (brzina_podloge > 0.5)
            Provera_Za_Animaciju = true;



    }
    
  
    
   
   
    
}
