using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalAch : MonoBehaviour {
    public static int Sladoled_ACH;
    public static int Poeni_10_ACH;
    public static int Poeni_50_ACH;
    public static int Poeni_100_ACH;
    public static int Odskok_ACH;//Odbijanja od ivice(zidove)
    public static int Poeni_Odbacivanja_ACH;//Pokusajte da u odredjenom broju odbacivanja postignete odredjeni broj poena





    public static float sladoled_brojac = 0;
    public static float Poeni10_brojac = 0;
    public static float Poeni50_brojac = 0;
    public static float Poeni100_brojac = 0;
    public static float Odskok_brojac = 0;
    public static float Poeni_Odskok_brojac = 0;
    private void Start()
    {
        Sladoled_ACH = PlayerPrefs.GetInt("Achievements_Sladoled1");
        Poeni_10_ACH= PlayerPrefs.GetInt("Achievements_Poeni10");
        Poeni_50_ACH = PlayerPrefs.GetInt("Achievements_Poeni30");
        Poeni_100_ACH = PlayerPrefs.GetInt("Achievements_Poeni60");
        Odskok_ACH = PlayerPrefs.GetInt("Achievements_Odskok");
        Poeni_Odbacivanja_ACH = PlayerPrefs.GetInt("Achievements_PoeniOdbacivanja");






        DontDestroyOnLoad(this.gameObject);


    }

}
