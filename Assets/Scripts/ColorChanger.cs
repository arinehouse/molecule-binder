using UnityEngine;
using System.Collections;

public class ColorChanger : MonoBehaviour {

	bool colourChangeCollision = false;

	void OnTriggerEnter(Collider other) {
		colourChangeCollision = true;
	}

	void OnTriggerExit(Collider other) {
		colourChangeCollision = false;
	}

	void checkColourChange()
	{        
		if (colourChangeCollision) {
			transform.GetComponent<Renderer> ().material.color = Color.green;	
		} else {
			transform.GetComponent<Renderer> ().material.color = Color.blue;
		}
	}

	void Update()
	{
		checkColourChange();
	}
}
