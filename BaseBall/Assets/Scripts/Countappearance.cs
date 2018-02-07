using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countappearance : MonoBehaviour {

	public GameObject st;
	public GameObject s1;
	public GameObject s2;
	public GameObject o1;
	public GameObject o2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		strike gm = st.GetComponent<strike>();
		int i = gm.s;
		int h = gm.o;
		if (i == 1){
			s1.SetActive(true);
		}else if(i == 2){
			s2.SetActive(true);
		}else if(i == 0){
			s1.SetActive(false);
			s2.SetActive(false);
		}
		if (h == 1){
			o1.SetActive(true);
		}else if(h == 2){
			o2.SetActive(true);
		}else if(h == 0){
			o1.SetActive(false);
			o2.SetActive(false);
		}
	}
}
