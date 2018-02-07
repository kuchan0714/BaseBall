using UnityEngine;
using System.Collections;

public class Hitting : MonoBehaviour {
	Rigidbody be;
	private Vector3 position;
	private Vector3 screenToWorldPointPosition;

	public GameObject Ball;
	public int speed;
	// Use this for initialization
	void Start () {
		be = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){

			GameObject balls= GameObject.Instantiate(Ball, this.transform.position, Quaternion.identity)as GameObject;
			Vector3 ball;
			ball = this.gameObject.transform.forward * speed;
			balls.GetComponent<Rigidbody>().AddForce(ball);

			/*
			position = Input.mousePosition;
			position.z = Camera.main.transform.position.z + 1;
			screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position); 
			kokokara
			*/
		}
	}
}
