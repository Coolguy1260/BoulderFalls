using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour {
	int colorID;
	void Start() {
		colorID = PlayerPrefs.GetInt("colorID", 1);
		Material playerMaterial = GetComponent<Renderer>().material;
		if(colorID == 1) {
			playerMaterial.color = Color.green;
		} else if (colorID == 2) {
			playerMaterial.color = Color.red;
		} else if (colorID == 3) {
			playerMaterial.color = Color.cyan;
		} else if (colorID == 4) {
			playerMaterial.color = new Color(0.62f, 0.31f, 0f);
			playerMaterial.SetFloat("_Metallic", 1f);
		} else if (colorID == 5) {
			playerMaterial.color = Color.white;
			playerMaterial.SetFloat("_Metallic", 1f);
		} else if (colorID == 6) {
			playerMaterial.color = new Color(1f, 1f, 0f);
			playerMaterial.SetFloat("_Metallic", 1f);
		}
	}
}