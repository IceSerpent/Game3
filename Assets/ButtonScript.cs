using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {


	public GameObject capsule;
	public Renderer objectR;
	public Material on;
	public Material off;

	// Use this for initialization
	void Start () {
		objectR.material = off;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {

		if (other.name == "Player") {
			objectR.material = on;
			Destroy (capsule);
		}
	}

}
