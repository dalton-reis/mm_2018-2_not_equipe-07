using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btn_replay : MonoBehaviour {

	// Use this for initialization
	
    public void Resetar()
    {
        Debug.Log("scene" +SceneManager.GetActiveScene().name);
        GlobalClass.Instance().ResetaMundO();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     
    }    
    

} 

