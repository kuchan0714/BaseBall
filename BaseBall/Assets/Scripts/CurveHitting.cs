using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveHitting : MonoBehaviour {

	//public GameObject Curve;
	public GameObject Batter;
	public Quaternion direct;
	public float force = 200.0f;
	public GameObject _parent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision junjun){
		if(junjun.gameObject.tag == "Bat"){
			_parent = transform.root.gameObject;
			this.transform.rotation = _parent.transform.rotation;
			var rig = this.GetComponent<Rigidbody>();
			rig.AddForce(transform.forward * force);
		}
	}
}
