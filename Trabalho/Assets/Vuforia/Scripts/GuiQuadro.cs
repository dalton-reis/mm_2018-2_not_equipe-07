using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GuiQuadro : MonoBehaviour {

    public Vector2 position = new Vector2(50,50);
    public Vector2 size =  new Vector2(250,250);
    public String title = "Titulo";
    public String text =  "textetextextasdfsdfsadfsadfasdffasdfadfasdfasdfasdfadsfasdfsdafasdfsd";
    
    public Boolean ExibirTexto;
    public GUISkin custonSkin;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

      

    }
    /*

    public GuiQuadro(Vector2 position, Vector2 size , String title, String text)
    {
        this.position = position;
        this.size = size;
        this.title = title;
        this.text = text;
    }
    */

    private void OnGUI()
    {
        if (GlobalClass.StatusJOGO.FIMDEJOGO == GlobalClass.Instance().statusAtual) { 

        GUI.skin = custonSkin;
        //GUI.Box(quadro, title);
        Debug.Log("GUI sKIN" + GUI.skin.name);
        GUILayout.BeginArea(new Rect(position, size));

        String title = "FIM DE JOGO";
        String text = "Você acertou "+GlobalClass.Instance().getQtdAcertos() +" de " + GlobalClass.Instance().qtdInsetos +  " respostas.";
        GUILayout.TextField(title);
        if (!ExibirTexto)
        {
            GUILayout.TextArea(text);
        }
        GUILayout.EndArea();


        }
        else
        {

        }
        

    }


   
}
