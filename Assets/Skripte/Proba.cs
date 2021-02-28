using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Proba : MonoBehaviour {
    public Button Dugme;
	
	void Start () {
        Dugme.onClick.AddListener(Rotiraj);
        
    }
	
	
	void Update () {
       
        
	}
    void Rotiraj()
    {
        Dugme.transform.Rotate(0, 0, 10);
    }
}
