using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class strike : MonoBehaviour {

	private bool isFoul = false;
	public int s = 0;
	public int o = 0;
	public Image image;
	public GameObject cg;
	public GameObject a;
	public float imtime = 0.0f;
	public float time = 0.0f;
	public int b = 0;

	// Use this for initialization
	void Start () {
		
	}
	public void OnCollisionEnter (Collision collision) {
		if(collision.gameObject.tag == "Ball"){
			image.gameObject.SetActive(true);
			if(s <= 2){
				s ++;
				Debug.Log(s +"ストライク");
			}
			if(s == 3) {
				s = 0;
				o ++;
				Debug.Log("ストライク！バッターアウト！");
				if(o <= 2) {
					Debug.Log(o + "アウト");
				}
				if(o == 3){
					Debug.Log("スリーアウト！チェンジ");
				}
			}
		}
		if(collision.gameObject.tag == "Foul"){
			if(s != 2){
				s++;
			}
		}
	}
	// Update is called once per frame
	void Update () {
		if(o == 0){
			a.SetActive(false);
			time = 0.0f;
		}
		if (o == 3){
			time += Time.deltaTime;
			a.SetActive(true);
			if(time > 0.5f){
				a.SetActive(false);
				time = 10.0f;
				o = 0;
			}
		}
	}
}
