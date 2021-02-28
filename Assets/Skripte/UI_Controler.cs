using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controler : MonoBehaviour {
    public GameObject UICredits;
    public GameObject DefaultUI;
    public GameObject UIAchievements;
    public AudioSource Click;
    private void Start()
    {
        UICredits.active = false;
        DefaultUI.active = true;
        UIAchievements.active = false;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && DefaultUI.active==true)
        {
            Quit();
        }
    }
    public void GlavnaScena()
    {
        Application.LoadLevel("Glavna_Scena");
        Click.Play();

    }
    public void PocetnaScena()
    {
        Application.LoadLevel("Pocetna_Scena");


    }
    public void Quit()
    {
        Application.Quit();
        Click.Play();
        Debug.Log("Napustili ste igricu");
    }
    public void OtvrotiCredits()
    {
        Click.Play();
        UICredits.active = true;
        DefaultUI.active = false;


    }
    public void ZatvoriCredits()
    {
        Click.Play();
        UICredits.active = false;
        DefaultUI.active = true;


    }
    public void OtvrotiACH()
    {
        Click.Play();
        UICredits.active = false;
        DefaultUI.active = false;
        UIAchievements.active = true;


    }
    public void ZatvoriACH()
    {
        Click.Play();
        UIAchievements.active = false;
        DefaultUI.active = true;


    }




}
