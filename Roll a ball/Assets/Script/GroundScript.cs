using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground1Script : MonoBehaviour {
	private Rigidbody rb1;
	private float timer1 = PlayerController5.timer;
	// Use this for initialization
	void Start () {

		rb1 = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision Grounde){
		if (Grounde.gameObject.CompareTag ("Player")) {
			timer1 = 5.0f;
			PlayerController5.timer = timer1;
		}
	}
}
