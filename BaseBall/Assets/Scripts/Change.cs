using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

	public GameObject cg;
	public GameObject a;
	public float imtime = 0.5f;
	public float time = 0.0f;
	public int b = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		strike s = cg.GetComponent<strike>();
		int i = s.o;
		if(i == 0){
			a.SetActive(false);
		}
		if (i == 3){
				a.SetActive(true);
		}
	}
}
