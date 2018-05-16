using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour {
	public GameObject pet;
	public GameObject shop;
	public GameObject sHappiness;
	public GameObject sHunger;
	public GameObject sHygiene;
	public GameObject sHealth;
	public GameObject sGold;
	public GameObject pDonut;
	public GameObject pSmoothie;
	public GameObject pBall;
	public GameObject pBandaid;
	public GameObject pSoap;

	// Update is called once per frame
	void Update () {
		//monitor and update the stats
		sHappiness.GetComponent<Text> ().text = "" + pet.GetComponent<pet> ().happiness;
		sHunger.GetComponent<Text> ().text = "" + pet.GetComponent<pet> ().hunger;
		sHygiene.GetComponent<Text> ().text = "" + pet.GetComponent<pet> ().hygiene;
		sHealth.GetComponent<Text> ().text = "" + pet.GetComponent<pet> ().health;
		sGold.GetComponent<Text> ().text = "" + shop.GetComponent<shop> ().gold;
		pDonut.GetComponent<Text> ().text = "" + shop.GetComponent<shop> ().donut.price;
		pSmoothie.GetComponent<Text> ().text = "" + shop.GetComponent<shop> ().smoothie.price;
		pBall.GetComponent<Text> ().text = "" + shop.GetComponent<shop> ().ball.price;
		pBandaid.GetComponent<Text> ().text = "" + shop.GetComponent<shop> ().bandaid.price;
		pSoap.GetComponent<Text> ().text = "" + shop.GetComponent<shop> ().soap.price;

	}
}
