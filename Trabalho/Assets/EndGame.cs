using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {
    //public float distanceZ = 0;

       

    // Use this for initialization
    void Start()
    {




        //for in respostas certas
        //
        /*Dictionary<string, ArrayList> arrAcertados = GlobalClass.Instance().respostas;




      float PosicaoX = -15;
      foreach(var obj in arrAcertados) {
        string NomeAcertado = obj.Key;
        string NomeObjeto = "";
        NomeAcertado.ToLower();

        switch (NomeAcertado)
        {
            case "borboleta":
                NomeObjeto = "ButterflyColor1";
                break;
            case "mosca":
                NomeObjeto = "FlyColor1";
                break;
            case "vespa":
                NomeObjeto = "WaspColor1";
                break;
            case "libelula":
                NomeObjeto = "CockroachColor1";
                break;
            case "joaninha":
                NomeObjeto = "LadyBugColor1";
                break;
            case "barata":
                NomeObjeto = "CockroachColor1";
                break;
        }
        GameObject insetoObject = Resources.Load<GameObject>(NomeObjeto);
        Vector3 position = Vector3.zero;
        Quaternion rotation = Quaternion.identity;
        Debug.Log("Acertado:" + NomeAcertado + NomeObjeto);

        float posicaoZ = 60;
        //int qtdInsetos = 3;
        //  posicaoZ = (qtdInsetos * posicaoZ )/ 6;
        Debug.Log(posicaoZ);

        position.z = posicaoZ;
        position.x = PosicaoX;
        position.y = -10;
        //pos.y = 10;   
        rotation.y = 175;
        rotation.z = -70;    
        //insetoObject.
        Instantiate(insetoObject, position, rotation);
        PosicaoX += 7;
    }
    */

    }



    //}
    // Update is called once per frame
    void Update () {


       
	}
}
