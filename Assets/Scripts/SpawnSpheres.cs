using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnSpheres : MonoBehaviour {
	float SpawnTime;
	public GameObject Enemy;
	public GameObject Bagel;
	void Start() {
		PlayerPrefs.SetInt("Score", 0);
		SpawnTime = PlayerPrefs.GetFloat("diff");
	}
	void Update () {
		SpawnTime -= Time.deltaTime;
		if(SpawnTime < 0) {
			if(PlayerPrefs.GetInt("dough", 0) == 1) {
				Instantiate(Bagel, new Vector3(Random.Range(-9, 9), 20, -18), Quaternion.Euler(0, 0, Random.Range(70, 100)));
			} else {
				Instantiate(Enemy, new Vector3(Random.Range(-9, 9), 20, -18), Quaternion.identity);
			}
			SpawnTime = PlayerPrefs.GetFloat("diff");
		}
	}
}
