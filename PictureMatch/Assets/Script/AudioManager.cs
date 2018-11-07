using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	private AudioSource audioS;

	void Start () {
		audioS = GetComponent<AudioSource> ();
		audioS.Play ();
	}

}
