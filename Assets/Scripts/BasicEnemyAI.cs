using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyAI : MonoBehaviour {

	GameObject player;
	public PlayerController playerScript;
	UnityEngine.AI.NavMeshAgent enemy;

	public int range;
	private Vector3 distance;



	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerScript = FindObjectOfType<PlayerController> ();
		enemy = GetComponent<UnityEngine.AI.NavMeshAgent> ();


	}



	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance (transform.position, player.transform.position);
		if (distance <= range) {
			enemy.destination = player.transform.position;
		}

	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Player") {
			Vector3 attackDir = player.transform.position - transform.position;
			attackDir = attackDir.normalized;

			playerScript.Injure (1, attackDir);
		}
	}
}
