﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickButtonAwy : MonoBehaviour {

	public void changeToScene(int sceneToChangeTo){
	SceneManager.LoadScene (sceneToChangeTo);
	}

	public void restartScene(int sceneToChangeTo){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void quitApp(){
		Application.Quit();
	}


}
