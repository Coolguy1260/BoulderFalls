using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RecreateSphere : MonoBehaviour {
	void OnTriggerEnter (Collider other) {
		gameObject.transform.position = new Vector3(Random.Range(-9, 9), 20, -18);
		PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
	}
}
