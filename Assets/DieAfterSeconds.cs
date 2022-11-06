using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieAfterSeconds : MonoBehaviour {
	public float seconds = 5.0f;
	// Start is called before the first frame update
	void Start() {
		if( seconds != 0) {
			StartCoroutine(DieAfter());
		}
	}

	// Update is called once per frame
	void Update() {

	}

	private IEnumerator DieAfter() {
		{
			yield return new WaitForSeconds(seconds);
			Destroy(this.gameObject);
		}
	}

}
