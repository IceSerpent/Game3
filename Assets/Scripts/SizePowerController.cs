using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizePowerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Player") {
			Destroy (gameObject);
			other.transform.localScale *= 2;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
