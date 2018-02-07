using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pitcher : MonoBehaviour {

	public GameObject ball;
	public float power = 100f;
	public Vector3 direction;

	void Start () {
		StartCoroutine (Spawn ());
	}
	
	IEnumerator Spawn(){
		
		while (true) {
			var obj = Instantiate (ball, ball.transform.position,Quaternion.identity) as GameObject; 
			var rigidbody = obj.GetComponent<Rigidbody>();


			rigidbody.AddForce (direction * power, ForceMode.Impulse);
			yield return new WaitForSeconds(10f);
		}
	}
}
