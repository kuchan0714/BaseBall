using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pitcher : MonoBehaviour {

	public GameObject ball;
	public GameObject curve;
	public float power = 100f;
	public Vector3 direction;
	public int busu;

	void Start () {
		StartCoroutine (Spawn ());
	}
	
	IEnumerator Spawn(){
		while (true) {
			busu = Random.Range (1, 5);
			if(busu >= 2){
			var obj = Instantiate (ball, ball.transform.position,Quaternion.identity) as GameObject; 
			var rigidbody = obj.GetComponent<Rigidbody>();

			rigidbody.AddForce (direction * power, ForceMode.Impulse);
			}else if(busu == 1){
				Instantiate (curve);
			}
			yield return new WaitForSeconds(10f);
		}
	}
}
