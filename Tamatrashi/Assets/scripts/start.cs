using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {

	public GameObject startMenu;
	public GameObject optionMenu;
	public GameObject petMenu;


	public void startGame(){
		startMenu.SetActive (false);
		petMenu.SetActive (true);

	}

	public void options() {
		startMenu.SetActive (false);
		optionMenu.SetActive (true);
	}

	public void goBack(){
		optionMenu.SetActive (false);
		petMenu.SetActive (false);
		startMenu.SetActive (true);
	}


		
}
