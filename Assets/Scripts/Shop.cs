using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Shop : MonoBehaviour {
	public GameObject ShopUI;
	public Text CreditsText;
	void Start () {
		StartCoroutine(waitForAnim());
		CreditsText.text = "Credits: " + PlayerPrefs.GetInt("Credits", 0);
	}
	IEnumerator waitForAnim() {
		yield return new WaitForSeconds(5);
		ShopUI.SetActive(true);
	}
	public void menuButton() {
		SceneManager.LoadScene("MainMenu");
	}
	//this code is crazy inefficient but I couldn't get unity to take arguments in functions on button press
	public void greenButton() {
		PlayerPrefs.SetInt("colorID", 1);
	}
	public void redButton() {
		if(PlayerPrefs.GetInt("Credits", 0) >=  50) {
			PlayerPrefs.SetInt("colorID", 2);
			PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - 50);
			CreditsText.text = "Credits: " + PlayerPrefs.GetInt("Credits", 0);
		}
	}
	public void blueButton() {
		if(PlayerPrefs.GetInt("Credits", 0) >=  50) {
			PlayerPrefs.SetInt("colorID", 3);
			PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - 50);
			CreditsText.text = "Credits: " + PlayerPrefs.GetInt("Credits", 0);
		}
	}
	public void bronzeButton() {
		if(PlayerPrefs.GetInt("Credits", 0) >=  100) {
			PlayerPrefs.SetInt("colorID", 4);
			PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - 100);
			CreditsText.text = "Credits: " + PlayerPrefs.GetInt("Credits", 0);
		}
	}
	public void silverButton() {
		if(PlayerPrefs.GetInt("Credits", 0) >=  200) {
			PlayerPrefs.SetInt("colorID", 5);
			PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - 200);
			CreditsText.text = "Credits: " + PlayerPrefs.GetInt("Credits", 0);
		}
	}
	public void goldButton() {
		if(PlayerPrefs.GetInt("Credits", 0) >=  300) {
			PlayerPrefs.SetInt("colorID", 6);
			PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - 300);
			CreditsText.text = "Credits: " + PlayerPrefs.GetInt("Credits", 0);
		}
	}
	public void dough() {
		if(PlayerPrefs.GetInt("Credits", 0) >= 500 || PlayerPrefs.GetInt("DoughBought", 0) == 1) {
			PlayerPrefs.SetInt("dough", 1);
			if(PlayerPrefs.GetInt("DoughBought", 0) == 0) {
				PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - 500);
				CreditsText.text = "Credits: " + PlayerPrefs.GetInt("Credits", 0);
				PlayerPrefs.SetInt("DoughBought", 1);
			}
		}
	}
	public void thatIsANiceBoulder() {
		PlayerPrefs.SetInt("dough", 0);
	}
}
