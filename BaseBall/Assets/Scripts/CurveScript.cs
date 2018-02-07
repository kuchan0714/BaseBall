using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveScript : MonoBehaviour {

	public int time = 100;
	public string CurvePath = "CurvePath";

	// Use this for initialization
	void Start () {
		iTween.MoveTo(this.gameObject, iTween.Hash(
			"path", iTweenPath.GetPath(CurvePath),
			"time", time,
			"easeType", iTween.EaseType.linear,
			"orienttopath", true));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
