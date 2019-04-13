using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour {
	public Rigidbody rb;
	public GameObject particle;
	void Update () {
		if(Input.GetKey("left")) {
			gameObject.transform.Translate(Vector3.right * 0.25f);
		}
		if(Input.GetKey("right")) {
			gameObject.transform.Translate(Vector3.left * 0.25f);
		}
	}
	void OnTriggerEnter() {
		SceneManager.LoadScene("GameOver");
	}
	void OnCollisionEnter() {
		rb.useGravity = true;
		particle.SetActive(true);
	}
}
