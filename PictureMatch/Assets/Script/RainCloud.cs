using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCloud : MonoBehaviour {

	public GameObject[] objects;

	public GameObject[] points;

	bool rainOn = true;

//	void Start(){
//		StartCoroutine (ItemRain());
//	}

	void Update(){
		if(rainOn == true){
			StartCoroutine(ItemRain());
		}
	}

	IEnumerator ItemRain(){
		rainOn = false;
		int obj = Random.Range(0,objects.Length);
		int point = Random.Range (0,points.Length);
		Instantiate (objects[obj],points[point].transform.position,Quaternion.identity);
		yield return new WaitForSeconds (3f);
		rainOn = true;
	}
}
