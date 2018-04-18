using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed;
	public float jumpVal;
	public float gravityScale;
	public CharacterController player;
	private Vector3 moveGrid;
	public int score;
	public int health = 4;
	public int maxHealth = 4;
	public int lives = 5;
	public float knockTime;
	public float knockCount = -1f;
	public float knockForce;
	public float invTime;
	public float invCount;
	public float flashTime;
	public float flashCount;
	public Renderer visibility;
	private Vector3 RespawnPoint;
	public SpecialCoin coin;

	// Use this for initialization
	void Start () {
		player = GetComponent<CharacterController> ();
		RespawnPoint = transform.position;
		coin = FindObjectOfType<SpecialCoin> ();

	}
	
	// Update is called once per frame
	void Update () {


		//moveGrid = new Vector3 (Input.GetAxis ("Horizontal") * speed, moveGrid.y, Input.GetAxis ("Vertical") * speed);


		float yVal = moveGrid.y;
		if (knockCount <= 0) {
			moveGrid = (transform.forward * Input.GetAxis ("Vertical")) + (transform.right * Input.GetAxis ("Horizontal"));
			moveGrid = moveGrid.normalized * speed;
			moveGrid.y = yVal;
			if (player.isGrounded) {
			
				moveGrid.y = 0f;

			if (Input.GetButtonDown ("Jump")) {
				moveGrid.y = jumpVal;
			}
					
			}

		} else {
			knockCount -= Time.deltaTime;
		}
			
		moveGrid.y = moveGrid.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
		player.Move (moveGrid * Time.deltaTime);
		// Debug.Log("Health: " + health);

		if (invCount > 0) {
			invCount -= Time.deltaTime;
			flashCount -= Time.deltaTime;
			if (flashCount <= 0) {
				visibility.enabled = !visibility.enabled;
			}
		} else {
		 	visibility.enabled = true;
		}

		if (health <= 0) {
			Respawn ();
		}

		if (score > 9999) {
			score = 9999;
		}
	}

	public void knockback (Vector3 direction) {
		knockCount = knockTime;

		moveGrid = direction * knockForce;
		moveGrid.y = knockForce;
	}

	public void Injure (int damage, Vector3 direction) {
		if (invCount <= 0) {
			invCount = invTime;
			health -= damage;
			knockback (direction);
		}
	}

	public void Respawn () {
		lives--;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);﻿
		transform.position = RespawnPoint;
		knockCount = 0;
		invCount = 0;
		flashCount = 0;
		health = maxHealth;

	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Coin 1") {
			coin.coin1 = true;
		}

		if (other.tag == "Coin 2") {
			coin.coin2 = true;
		}

		if (other.tag == "Coin 3") {
			coin.coin3 = true;
		}
	}
}

