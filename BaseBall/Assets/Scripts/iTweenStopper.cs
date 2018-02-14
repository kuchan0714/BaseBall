using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iTweenStopper : MonoBehaviour {

	public GameObject Bat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "Bat"){
			Debug.Log("owata");
			iTween.Stop(this.gameObject);
		}
	}
}
