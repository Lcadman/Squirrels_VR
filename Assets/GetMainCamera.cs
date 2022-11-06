using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainCamera : MonoBehaviour {
	private Camera mainCam;
	// Start is called before the first frame update
	void Start() {
		if (GetComponent<Canvas>() != null) {
			GetComponent<Canvas>().worldCamera = mainCam;
		}
		mainCam = Camera.main;
		FacePlayer();
	}


	void FacePlayer() {
		transform.LookAt(2 * transform.position - mainCam.transform.position);
	}
	// Update is called once per frame
	void Update() {
		//FacePlayer();
		
	}
}



