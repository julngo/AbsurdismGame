using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pet : MonoBehaviour {
	private float counter;
	public Text petName;
	public int health;
	public int hygiene;
	public int hunger;
	public int happiness;
	public Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		//init values
		string name = PlayerPrefs.GetString("petName");
		petName.text = name;
		//init updateStatus
		updateStatus("happiness", 0);
	}
	
	// Update is called once per frame
	void Update () {
		//decreasing stats
		counter += Time.deltaTime;
		if (counter >= 5) {
			string stat = getRandomStat ();
			updateStatus (stat, -1);
			counter = 0;
		}
	}
	void OnMouseDown(){
		if (getPerc () <= 0.5) {
			animator.Play ("angry");
			updateStatus ("happiness", -1);
		} else {
			animator.Play ("idle2");
			updateStatus ("happiness", 1);
		}
	}
	public void playAnimOnItem(string item){
		switch (item) {
		case "donut":
			if (getPerc () <= 0.5) {
				animator.Play ("barf");
				updateStatus ("health", -1);
				updateStatus ("hygiene", -1);
			}
			break;
		case "smoothie":
			if (getPerc () <= 0.5) {
				animator.Play ("barf");
				updateStatus ("happiness", -1);
				updateStatus ("hygiene", -1);
			}
			break;
		case "ball":
			if (happiness >= 8) {
				animator.Play ("idle2");
			}
			break;
		case "bandaid":
			break;
		case "soap":
			if (hygiene >= 8) {
				animator.Play ("clean");
			}
			break;
		default:
			return;
		}
	}
	public void updateStatus(string stat, int val){
		int currentStatVal = (int)this.GetType().GetField(stat).GetValue(this);

		if (currentStatVal + val > 10) {
			return;
		} else if (currentStatVal + val < 0) {
			return;
		}else {
			this.GetType ().GetField (stat).SetValue (this, currentStatVal + val);
		}

		if (health < 6) {
			//plays sick animation
		} else if (hygiene < 6) {
			animator.Play ("dirt");
		} else if (hunger < 6) {
			animator.Play ("cry");
		} else if (happiness < 6 && happiness > 0) {
			animator.Play ("angry");
		}else {
			animator.Play ("idle");
		}
	}
	//end of updateStatus
	string getRandomStat(){
		string stat;
		string[] array = {"happiness","hunger","hygiene","health"};
		int random = Random.Range (0, 4);
		stat = array [random];
		return stat;
	}

	//generates percetange 
	float getPerc(){
		float num = Random.value;
		num = Mathf.Round(num * 10f) / 10f;
		return num;
	}
}
