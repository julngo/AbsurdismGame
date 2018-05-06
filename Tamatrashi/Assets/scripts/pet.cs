using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pet : MonoBehaviour {

	public int health;
	public int hygiene;
	public int hunger;
	public int happiness;

	// Use this for initialization
	void Start () {
		//init values
		health = 7;
		hygiene = 7;
		hunger = 7;
		happiness = 7;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) { //if pet was clicked
			updateStatus("happiness", 1);
		}
	}

	void updateStatus(string type, int val){
		//checks and update the corresponding stat
		switch (type){
		case "health":
			if (health + val > 10) {
				return;
			} else {
				health = health + val;
			}
			break;
		case "hygiene":
			if (hygiene + val > 10) {
				return;
			} else {
				hygiene = hygiene + val;
			}
			break;
		case "hunger":
			if (hunger + val > 10) {
				return;
			} else {
				hunger = hunger + val;
			}
			break;
		case "happiness":
			if (happiness + val > 10) {
				return;
			} else {
				happiness = happiness + val;
			}
			break;
		default:
			return;
		}
	}
}
