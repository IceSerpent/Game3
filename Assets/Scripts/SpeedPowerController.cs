using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Player") {
			Destroy (gameObject);
			other.GetComponent<PlayerController> ().speed += 10;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
