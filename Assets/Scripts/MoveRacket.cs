using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour {

	public float speed = 30;
	public string axis = "";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	//Update every interval, physics stuff.
	void FixedUpdate(){

		float v = Input.GetAxisRaw (axis);
		GetComponent<Rigidbody2D>().velocity = new Vector2 (0, v) * speed;
	
	}
}
