using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class loadData : MonoBehaviour {

    public PersonData data;
    public Image avatar;
    public Text imie;
    public Text nazwisko;
    public Text wiek;
    public Text plec;

    void Start () {
        avatar.sprite = data.photo;
        imie.text = data.imie;
        nazwisko.text = data.nazwisko;
        wiek.text = data.wiek.ToString();
        plec.text = data.plec;
	}
	
}
