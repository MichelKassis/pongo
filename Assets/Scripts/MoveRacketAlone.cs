using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacketAlone : MonoBehaviour
{

	float barPos;

	// Use this for initialization
	void Start()
	{


	}

	// Update is called once per frame
	void Update()
	{
		barPos = GameObject.Find("Ball").transform.position.y;

		Vector3 tmpPosition = transform.position;
		tmpPosition.y = barPos;
		transform.position = tmpPosition;

	}
}
