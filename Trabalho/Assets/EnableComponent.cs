using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnableComponent : MonoBehaviour {
    public GameObject go;
    public GameObject guiQuadros;
   // public GameObject btn_play;
    //public GameObject intro;

    // Use this for initialization
    void Start () {
        go.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (GlobalClass.StatusJOGO.FIMDEJOGO == GlobalClass.Instance().statusAtual)
        {
            if (!go.activeSelf)
            {
                go.SetActive(true);
                guiQuadros.SetActive(true);

            }
        }
        else
        {
            go.SetActive(false);
            guiQuadros.SetActive(false);
        }
    }


}
