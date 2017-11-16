using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour {

	void Awake () {

		GameObject[] backMusic = GameObject.FindGameObjectsWithTag("backMusic");

		if (backMusic.Length > 1) {
			Destroy (this.gameObject);
		} else {
			DontDestroyOnLoad (this.gameObject);
		}

	}

}
