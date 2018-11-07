using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Rigidbody rb;
	AudioSource[] sources;

	void Start () {
		rb = GetComponent<Rigidbody> ();
		sources = GetComponents<AudioSource> ();
	}

	void FixedUpdate(){
		
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			rb.AddForce (Vector3.forward * 8.0f,ForceMode.Impulse);
			sources [0].Play ();
            rb.isKinematic = false;
        }

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			rb.AddForce (Vector3.left * 8.0f,ForceMode.Impulse);
			sources [0].Play ();
            rb.isKinematic = false;
        }

		if(Input.GetKeyDown(KeyCode.DownArrow)){
			rb.AddForce (Vector3.back * 8.0f,ForceMode.Impulse);
			sources [0].Play ();
            rb.isKinematic = false;
        }

		if(Input.GetKeyDown(KeyCode.RightArrow)){
			rb.AddForce (Vector3.right * 8.0f,ForceMode.Impulse);
			sources [0].Play ();
            rb.isKinematic = false;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.isKinematic = true;
        }
    }

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Tears"){
			sources [1].Play ();
		}
	}
}
