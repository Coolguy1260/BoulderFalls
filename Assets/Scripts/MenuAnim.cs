using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuAnim : MonoBehaviour {
	public Animator anim;
	public GameObject object1;
	public GameObject diff1;
	public GameObject shop1;
	public void ButtonBoop() {
		anim.SetBool("Diff", true);
		object1.SetActive(false);
		StartCoroutine(waiter());
	}
	public void ShopBoop() {
		SceneManager.LoadScene("Shop");
	}
	public void EasyMode() {
		PlayerPrefs.SetFloat("diff", 2f);
		SceneManager.LoadScene("MainGame");
	}
	public void MediumMode() {
		PlayerPrefs.SetFloat("diff", 1f);
		SceneManager.LoadScene("MainGame");
	}
	public void HardMode() {
		PlayerPrefs.SetFloat("diff", 0.5f);
		SceneManager.LoadScene("MainGame");
	}
	IEnumerator waiter() {
		yield return new WaitForSeconds(3);
		diff1.SetActive(true);
	}
}