using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nameSubmit : MonoBehaviour {

	public InputField input;

	public void submit(){
		PlayerPrefs.SetString ("petName", input.text);
		SceneManager.LoadScene ("game");
	}
}
