using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveHitting : MonoBehaviour {

	public GameObject Calbee;
	public GameObject Batter;
	public Quaternion direct;
	public float force = 70.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision junjun){
		direct = Batter.transform.localRotation;
		Vector3 BatterAngles = direct.eulerAngles;
		if(junjun.gameObject == Calbee){
			this.GetComponent<Rigidbody>().AddForce(BatterAngles * force, ForceMode.Impulse);
		}
	}
}
