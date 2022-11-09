using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CarAlarmScenario : MonoBehaviour {
	public List<UnityEvent> events;
	public float delay = 5.0f;
	// Start is called before the first frame update
	void Start() {
		//StartCoroutine(runScenario());
	}

	public IEnumerator runScenario() {
		//print("ran");
		events[0].Invoke();
		yield return new WaitForSeconds(delay/3);
		events[1].Invoke();
		yield return new WaitForSeconds(delay);
		events[2].Invoke();
		yield return new WaitForSeconds(delay);


	}

	public void StartScenario() {
		StartCoroutine(runScenario());
	}
	// Update is called once per frame
	void Update() {

	}
}
