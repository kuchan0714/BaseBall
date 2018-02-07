using UnityEngine;
using System.Collections;
using DG.Tweening;
public class JudgeScript : SingletonMonoBehaviour<JudgeScript> {

	//  Text wo public de get daze!

	// Use this for initialization
	void Start () {
		this.transform.localScale = Vector3.zero;

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Maguro (){
		//Debug.Log ("Maguro!!!!");
	}
	public void Show(/*bool isSafe  */){
		// Safe nara text ni  safe tte ireru.
		this.transform.DOScale (Vector3.one, 0.3f);
	}
}
