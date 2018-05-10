using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class optionMenu : MonoBehaviour {

	public AudioMixer audioMixer;

	public void setVolume(float volume){
		audioMixer.SetFloat ("volume", volume);
	}

	public void setFullScreen(bool isFullScr){
		Screen.fullScreen = isFullScr;
	}
}
