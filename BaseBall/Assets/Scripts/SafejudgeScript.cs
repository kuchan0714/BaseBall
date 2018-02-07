using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class SafejudgeScript : MonoBehaviour {

	public Text safe;

	// Use this for initialization
	void Start () {
		//find
		//findで見つけたオブジェクトのスケールを０にする。
		GameObject safe = GameObject.FindGameObjectWithTag("Safe");
		safe.transform.localScale = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnCollisionEnter (Collision collision){
		
		if(collision.gameObject.CompareTag("Safezone")){
			Debug.Log("INNNNNNN");
			safe.gameObject.SetActive(true);
		}
	}

	public void Change(){
		safe.transform.localScale = new Vector3(1, 1, 1);
	}
}
