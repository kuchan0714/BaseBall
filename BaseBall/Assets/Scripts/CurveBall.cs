using UnityEngine;
using System.Collections;

public class CurveBall : MonoBehaviour {
	private bool isSafe = false;
	private Rigidbody _rigidbody;
	public bool showResultFlg = false;
	private bool isFoul = false;
	void Start () {
		_rigidbody = this.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		//		if(Input.GetKeyDown(KeyCode.A)){
		//			if(isSafe){
		//				Debug.Log ("セーフ！");
		//			}else if(isFoul){
		//				Debug.Log ("ファウル！");
		//			}else{
		//				Debug.Log ("アウト！");
		//			}
		//		}
		//Debug.Log ("速度: " + _rigidbody.velocity.magnitude);
		if(_rigidbody.velocity.magnitude <= 0.3f){
			_rigidbody.velocity = Vector3.zero;
			_rigidbody.gameObject.transform.rotation = Quaternion.Euler (Vector3.zero);
			if(showResultFlg == false) {
				JudgeScript.Instance.Maguro ();
				showResultFlg = true;
			}
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.CompareTag("Safezone")){
			isSafe = true;
			Debug.Log ("Enter SafeZone");
		}
	}

	void OnTriggerExit(Collider other){
		if(other.CompareTag("Safezone")){
			isSafe = false;
			Debug.Log ("Exit SafeZone");
		}
	}
}
