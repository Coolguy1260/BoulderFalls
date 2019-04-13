using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SetScoreText : MonoBehaviour {
	public Text scoreText;
	public Text highScoreText;
	public Text creditsText;
	void Start () {
		scoreText.text = "Your score was: " + PlayerPrefs.GetInt("Score");
		if(PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighScore", 0)) {
			PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
		}
		float flo = ((float)PlayerPrefs.GetInt("Score"));
		PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits", 0) + Mathf.RoundToInt(flo / 10f));
		highScoreText.text = "High score: " + PlayerPrefs.GetInt("HighScore");
		creditsText.text = "Credits: " + PlayerPrefs.GetInt("Credits");
	}
	public void ButtonOnClick() {
		SceneManager.LoadScene("MainGame");
	}
	public void MainMenuOnClick() {
		SceneManager.LoadScene("MainMenu");
	}
}
