using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VButton : MonoBehaviour, IVirtualButtonEventHandler {

    private GlobalClass global = GlobalClass.Instance();
    public GameObject game;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if(global.ultimoVisto != "") { 
            if (vb.VirtualButtonName == "VirtualButtonTrue")
            {
                Debug.Log("Resposta INFORMADA VERDADEIRO ");
                global.insertResposta(global.ultimoVisto, true);
            }
            else if(vb.VirtualButtonName == "VirtualButtonFalse") {
                Debug.Log("Resposta INFORMADA FALSA ");
                global.insertResposta(global.ultimoVisto, false);
            }

            Debug.Log("Respostas CERTAS "+global.respostasAcertas());
            
            
            var rendererComponents = game.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = game.GetComponentsInChildren<Collider>(true);
            var canvasComponents = game.GetComponentsInChildren<Canvas>(true);

            // Disable rendering:
            foreach (var component in rendererComponents)
                component.enabled = false;

            // Disable colliders:
            foreach (var component in colliderComponents)
                component.enabled = false;

            // Disable canvas':
            foreach (var component in canvasComponents)
                component.enabled = false;

        }

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //throw new NotImplementedException();
    }

    // Use this for initialization
    void Start () {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);        
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
