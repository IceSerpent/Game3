using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHealth : MonoBehaviour {
	
	public PlayerController playerScript;
	private int health;
	private int max;
	private float healthRatio;

	// Use this for initialization
	void Start () {
		playerScript = FindObjectOfType<PlayerController> ();
		max = playerScript.maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		health = playerScript.health;
		healthRatio = (health * 1.0f/ max);
		// Debug.Log (healthRatio);
		transform.localScale = new Vector3 (healthRatio, 1, 1);
		
	}
}
