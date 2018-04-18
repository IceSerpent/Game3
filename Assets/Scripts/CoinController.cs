using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	private Transform coin;
	public GameObject particleEffect;
	// Use this for initialization
	void Start () {
		coin = GetComponent<Transform> ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Player") {
			Destroy (gameObject);
			other.GetComponent<PlayerController> ().score++;
			Instantiate (particleEffect, transform.position, transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (coin.position, Vector3.up, 100 * Time.deltaTime);
	}
}
