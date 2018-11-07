using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

	public string message;
	public GameObject obj;
	AudioSource audioS;

	// Use this for initialization
	void Start () {
		audioS = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag == "Wall"){
			Debug.Log ("あああ");
			StartCoroutine (TextSend());
		}
	}

	IEnumerator TextSend(){
		obj.GetComponent<Text> ().text = message;
		audioS.Play ();
		yield return new WaitForSeconds (8f);
		obj.GetComponent<Text> ().text = null;
	}
}
