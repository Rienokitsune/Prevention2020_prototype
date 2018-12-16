using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class loadEmail : MonoBehaviour {

    PersonData email;
    public Text adresat;
    public Text temat;
    public Text content;

    void Start () {
        email = GetComponentInParent<loadData>().data;
	}
	 
    public void LoadEmail(int id)
    {
        adresat.text = email._emails[id].adresat;
        temat.text = email._emails[id].temat;
        content.text = email._emails[id].content;
    }

}
