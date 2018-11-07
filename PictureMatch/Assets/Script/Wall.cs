using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

	void FixedUpdate () {
		
		this.gameObject.transform.Translate(0.005f,0,0);

	}
}
