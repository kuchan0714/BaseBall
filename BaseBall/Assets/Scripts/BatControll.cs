using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatControll : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// yは0.6から-0.5まで
//
		//		if(-0.5f < this.transform.localPosition.y && this.transform.localPosition.y < 0.6f){

		if(-0.5f <= this.transform.localPosition.y && this.transform.localPosition.y <= 0.8f){
			Debug.Log("by じゅんじゅん");
			if(Input.GetKey(KeyCode.S)){
				this.transform.position += new Vector3(0, -0.1f, 0);
			}else if(Input.GetKey(KeyCode.W)){
				this.transform.position += new Vector3(0, 0.1f, 0);
			}
		}

		if(-0.5f >= this.transform.localPosition.y){
			this.transform.localPosition = new Vector3(this.transform.localPosition.x, -0.5f, this.transform.localPosition.z);
		}

		if(0.8f <= this.transform.localPosition.y){
			this.transform.localPosition = new Vector3(this.transform.localPosition.x, 0.8f, this.transform.localPosition.z);
		}

	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "Curve"){
			col.gameObject.GetComponent<iTweenPath>().enabled = false;
		}

	}
}
