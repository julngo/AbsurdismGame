using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pet : MonoBehaviour {
	public Text petName;
	public int health;
	public int hygiene;
	public int hunger;
	public int happiness;
	Animator animator;
	private bool clickedBarf = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		//init values
		string name = PlayerPrefs.GetString("petName");
		petName.text = name;
		health = 7;
		hygiene = 7;
		hunger = 7;
		happiness = 7;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0) && !clickedBarf) { //if pet was clicked
			animator.Play("barf");
			updateStatus("happiness", -1);
			updateStatus("hygiene", -1);
			clickedBarf = true;
		}
	}

	void updateStatus(string type, int val){
		//checks and update the corresponding stat
		switch (type){
		case "health":
			if (health + val > 10) {
				return;
			} else if (health + val < 0) {
				return;
			}else {
				health = health + val;
			}
			break;
		case "hygiene":
			if (hygiene + val > 10) {
				return;
			} else if (hygiene + val < 0) {
				return;
			} else {
				hygiene = hygiene + val;
			}
			break;
		case "hunger":
			if (hunger + val > 10) {
				return;
			} else if (hunger + val < 0) {
				return;
			} else {
				hunger = hunger + val;
			}
			break;
		case "happiness":
			if (happiness + val > 10) {
				return;
			} else if (happiness + val < 0) {
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
