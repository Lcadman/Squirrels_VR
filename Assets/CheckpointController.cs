using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckpointController : MonoBehaviour {

	public GameObject checkpoint1;
	public GameObject checkpoint2;
	public GameObject checkpoint3;
	public UnityEvent event1;
	public UnityEvent event2;
	public UnityEvent event3;
	public bool event1ran = false;
	public bool event2ran = false;
	public bool event3ran = false;
	public bool distanceMode = false;
	public float minDistanceDelta = 5;

	public void DebugPrint(string s) {
		print(s);
	}

	private void CollisionMode() {
		if (checkpoint1.activeSelf) {
			if (checkpoint1.GetComponent<TouchingPlayer>().touching) {
				if (!event1ran) {
					event1ran = true;
					event1.Invoke();
				}
			}
		}
		if (checkpoint2.activeSelf) {
			if (checkpoint2.GetComponent<TouchingPlayer>().touching) {
				if (!event2ran) {
					event2ran = true;
					event2.Invoke();
				}

			}
		}

		if (checkpoint3.activeSelf) {
			if (checkpoint3.GetComponent<TouchingPlayer>().touching) {
				if (!event3ran) {
					event3ran = true;
					event3.Invoke();
				}
			}
		}

	}

	private void DistanceMode() {

		if (checkpoint1.activeSelf) {
			if (checkpoint1.GetComponent<DistanceTo>().distance < minDistanceDelta) {
				if (!event1ran) {
					event1ran = true;
					event1.Invoke();
				}
			}
		}
		if (checkpoint2.activeSelf) {
			if (checkpoint2.GetComponent<DistanceTo>().distance < minDistanceDelta) {
				if (!event2ran) {
					event2ran = true;
					event2.Invoke();
				}

			}
		}
		if (checkpoint3.activeSelf) {
			if (checkpoint3.GetComponent<DistanceTo>().distance < minDistanceDelta) {
				if (!event3ran) {
					event3ran = true;
					event3.Invoke();
				}
			}
		}
	}
	void Update() {
		if (!distanceMode) {
			CollisionMode();
		}
		else if (distanceMode) {
			DistanceMode();
		}


	}
}
