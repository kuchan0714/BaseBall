using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Hitter : MonoBehaviour {

	public float speed = 1f;
	public CapsuleCollider batCollider;

	// Use this for initialization
	void Start() {
	
	}

	void Update(){
//		if(Input.GetKeyDown(KeyCode.Space)){
//			this.transform.DOLocalRotate(Vector3.up *  120f,  time).SetRelative().SetEase(Ease.OutQuart);
//		}
	}
	void FixedUpdate() {
//		Debug.Log (batCollider.material.bounciness);
		if(Input.GetKey(KeyCode.Space)){
			this.transform.Rotate (Vector3.up * -1f * 120f * speed * Time.deltaTime, Space.World);
			batCollider.material.bounciness = 1f;
			batCollider.material.bounceCombine = PhysicMaterialCombine.Multiply;
		}else{
			batCollider.material.bounciness = 0.1f;
			batCollider.material.bounceCombine = PhysicMaterialCombine.Minimum;

		}
	}
}
