using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

	public float speed = 30;
	public Text countText1;
	public Text countText2;
	private Rigidbody2D rb2d;
	private int count1;
	private int count2;
	private Vector3 startPos;


	// Use this for initialization
	void Start () {

		count1 = 0;
		setCountText1 ();

		count2 = 0;
		setCountText2 ();

		startPos = transform.position;

		GetComponent<Rigidbody2D> ().velocity = Vector2.right * speed;
	}

	float hitFactor(Vector2 ballPos, Vector2 racketPos,
		float racketHeight) {
		// ascii art:
		// ||  1 <- at the top of the racket
		// ||
		// ||  0 <- at the middle of the racket
		// ||
		// || -1 <- at the bottom of the racket
		return (ballPos.y - racketPos.y) / racketHeight;
	}

	void OnCollisionEnter2D(Collision2D col) {
		// Note: 'col' holds the collision information. If the
		// Ball collided with a racket, then:
		//   col.gameObject is the racket
		//   col.transform.position is the racket's position
		//   col.collider is the racket's collider

		// Hit the left Racket?
		if (col.gameObject.name == "RacketLeft") {
			// Calculate hit Factor
			float y = hitFactor(transform.position,
				col.transform.position,
				col.collider.bounds.size.y);

			// Calculate direction, make length=1 via .normalized
			Vector2 dir = new Vector2(1, y).normalized;

			// Set Velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}

		// Hit the right Racket?
		if (col.gameObject.name == "RacketRight") {
			// Calculate hit Factor
			float y = hitFactor(transform.position,
				col.transform.position,
				col.collider.bounds.size.y);

			// Calculate direction, make length=1 via .normalized
			Vector2 dir = new Vector2(-1, y).normalized;

			// Set Velocity with dir * speed
			GetComponent<Rigidbody2D>().velocity = dir * speed;
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("WallLeft")) {
			count1 = count1 + 1;
			setCountText1();
			this.gameObject.transform.position = startPos;
             		//col.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
		}
		if (other.gameObject.CompareTag ("WallRight")){
			count2 = count2 + 1;
			setCountText2();
			this.gameObject.transform.position = startPos;
			//col.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
		}
	}

	void setCountText1(){
		countText1.text = "Count Player 2: " + count1.ToString ();
	}
	void setCountText2(){

		countText2.text = "Count Player 1: " + count2.ToString ();
	}





}
