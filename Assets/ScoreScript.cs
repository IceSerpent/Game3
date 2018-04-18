using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public PlayerController playerScript;
	private int score;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		playerScript = FindObjectOfType<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		score = playerScript.score;
		scoreText.text = score.ToString ("0000");
	}
}
