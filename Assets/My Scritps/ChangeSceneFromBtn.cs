using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ChangeSceneFromBtn : MonoBehaviour {

	public void CambiarNivel (){
		SceneManager.LoadScene ("Scene01"); 
	}
}
