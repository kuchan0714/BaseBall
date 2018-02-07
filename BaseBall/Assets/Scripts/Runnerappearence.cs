using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runnerappearence : MonoBehaviour {

	public GameObject ball;
	public GameObject secrunner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject == ball){
			secrunner.SetActive(true);
		}
	}
}
