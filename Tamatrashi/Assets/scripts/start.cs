using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour {

	public GameObject menu;
	public GameObject title;

	public void startGame(){
		menu.SetActive (true);
		title.SetActive (false);
	}
}
