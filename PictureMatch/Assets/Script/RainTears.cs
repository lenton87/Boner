using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainTears : MonoBehaviour {

	float waitTime = 0.15f;

	void OnCollisionEnter(Collision col){
		
		if(col.gameObject.tag == "Earth" || col.gameObject.tag == "Player" || col.gameObject.tag == "Wall"){
			StartCoroutine (Suecide());
		}
	}

	IEnumerator Suecide(){
		yield return new WaitForSeconds (waitTime);
		Destroy(this.gameObject);
	}
}
