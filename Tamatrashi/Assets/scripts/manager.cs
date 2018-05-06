using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour {

	public GameObject sHappiness;
	public GameObject sHunger;
	public GameObject sHygiene;
	public GameObject sHealth;
	public GameObject pet;

	// Update is called once per frame
	void Update () {
		//monitor and update the stats
		sHappiness.GetComponent<Text> ().text = "" + pet.GetComponent<pet> ().happiness;
		sHunger.GetComponent<Text> ().text = "" + pet.GetComponent<pet> ().hunger;
		sHygiene.GetComponent<Text> ().text = "" + pet.GetComponent<pet> ().hygiene;
		sHealth.GetComponent<Text> ().text = "" + pet.GetComponent<pet> ().health;

	}
}
