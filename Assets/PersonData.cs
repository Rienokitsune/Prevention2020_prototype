using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="NewPerson", menuName = "PersonDataAsset")]
public class PersonData : ScriptableObject {
    [System.Serializable]
        public class Email : System.Object
        {
            public string data;
            public string adresat;
            public string temat;
            [TextArea]public string content;
        }

    public Sprite photo;
    public string imie;
    public string nazwisko;
    public int wiek;
    public string plec;
    public string[] _messages;
    public Email[] _emails;
    public string[] _locations;


	
}
