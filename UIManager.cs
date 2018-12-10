using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text AmmoCount;
    private GunController gunCon;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        AmmoCount.text = "Ammo: " + gunCon.ammoNo + "/30";
	}
}
