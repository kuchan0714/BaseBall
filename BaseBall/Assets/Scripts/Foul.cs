using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foul : MonoBehaviour {

	public int f = 0;
	public float a = 0.0f;
	public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

/*	void OnTriggerrEnter(Collision colision){
		if (Collision.gameObject == ball){
			f = 1;
			Debug.Log("f = 1");
			a += Time.deltaTime;
			if (a < 5.0f){
				f = 0;
				Debug.Log("f = 0");
			}
		}
	}*/
}
