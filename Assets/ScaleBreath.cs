using Google.Protobuf.WellKnownTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBreath : MonoBehaviour {
	public float minScale = 1.5f;
	public float maxScale = 1.5f;
	public float lerpDuration = 4.0f;
	private float newScale;

	void Start() {
		StartCoroutine(scaleBreathing());
		//StartCoroutine(Lerp());
	}
	void Update() {
		//if (isIncreasing) {
		//	if (timeElapsed < lerpDuration) {
		//		valueToLerp = Mathf.Lerp(minScale, maxScale, timeElapsed / lerpDuration);
		//		timeElapsed += Time.deltaTime;
		//	}
		//	else {
		//		isIncreasing = false;
		//		timeElapsed = 0;
		//	}
		//} else {
		//	if (timeElapsed < lerpDuration) {
		//		valueToLerp = Mathf.Lerp(maxScale, minScale, timeElapsed / lerpDuration);
		//		timeElapsed += Time.deltaTime;
		//	}
		//	else {
		//		isIncreasing = true;
		//		timeElapsed = 0;
		//	}
		//}

		//transform.localScale = new Vector3(valueToLerp, valueToLerp, valueToLerp);
	}

	private IEnumerator scaleBreathing() {
		{
			while (true) {
				float timeElapsed = 0;
				while (timeElapsed < lerpDuration) {
					newScale = Mathf.Lerp(minScale, maxScale, timeElapsed / lerpDuration);
					transform.localScale = new Vector3(newScale, newScale, newScale);
					timeElapsed += Time.deltaTime;
					yield return null;
				}
				//Hold
				yield return new WaitForSeconds(lerpDuration);
				//Scale down
				timeElapsed = 0;
				while (timeElapsed < lerpDuration) {
					newScale = Mathf.Lerp(maxScale, minScale, timeElapsed / lerpDuration);
					transform.localScale = new Vector3(newScale, newScale, newScale);
					timeElapsed += Time.deltaTime;
					yield return null;
				}
				yield return new WaitForSeconds(lerpDuration);

			}
		}


	}
	IEnumerator Lerp() {
		float valueToLerp;
		float timeElapsed = 0;
		while (timeElapsed < lerpDuration) {
			valueToLerp = Mathf.Lerp(minScale, maxScale, timeElapsed / lerpDuration);
			transform.localScale =  new Vector3(valueToLerp, valueToLerp, valueToLerp);
			timeElapsed += Time.deltaTime;
			yield return null;
		}
	}




}
