using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quadScript : MonoBehaviour {

    private GlobalClass global = GlobalClass.Instance();
    public string nameBtn = "";

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        switch (this.nameBtn)
        {
            case "btnChar":
                GetComponent<TextMesh>().text = global.caracteristica;
            break;
            case "btnFunc":
                GetComponent<TextMesh>().text = global.funcoes;
            break;
            case "btnQuest":
                GetComponent<TextMesh>().text = global.perguntas;
            break;            
        }

       // if (global.botaoAtivo.Equals(nameBtn))
        
		
	}
}
