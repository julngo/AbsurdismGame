using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
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
	public GameObject gameOver;
	public GameObject gameStuff;
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

		if (pet.GetComponent<pet> ().happiness <= 0 || pet.GetComponent<pet> ().hunger <= 0 ||
		   pet.GetComponent<pet> ().hygiene <= 0 || pet.GetComponent<pet> ().health <= 0) {
			if (pet.transform.position.x < 600) {
				pet.GetComponent<pet> ().animator.Play ("leave");
				pet.transform.Translate (2, 0, 0);
			} else {
				pet.GetComponent<pet> ().animator.StopPlayback ();
				gameOver.SetActive (true);
				gameStuff.SetActive (false);
			}
		}
	}

	public void quitGame(){
		Application.Quit ();
	}

	public void restart(){
		SceneManager.LoadScene(0);
	}
}
