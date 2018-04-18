using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialCoin : MonoBehaviour {

	public Image coinSlot1;
	public Image coinSlot2;
	public Image coinSlot3;

	public bool coin1;
	public bool coin2;
	public bool coin3;

	private Color coinc1;
	private Color coinc2;
	private Color coinc3;

	// Use this for initialization
	void Start () {
		coin1 = false;
		coin2 = false;
		coin3 = false;

		coinc1 = coinSlot1.color;
		coinc2 = coinSlot2.color;
		coinc3 = coinSlot3.color;
	}
	
	// Update is called once per frame
	void Update () {
		if (coin1 == false) {
			coinc1.a = 0;
		} else {
			coinc1.a = 255;
		}

		if (coin2 == false) {
			coinc2.a = 0;
		} else {
			coinc2.a = 255;
		}

		if (coin3 == false) {
			coinc3.a = 0;
		} else {
			coinc3.a = 255;
		}

		coinSlot1.color = coinc1;
		coinSlot2.color = coinc2;
		coinSlot3.color = coinc3;
	}
}
