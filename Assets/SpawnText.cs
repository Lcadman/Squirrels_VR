using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class SpawnText : MonoBehaviour {
	//public Transform s1;
	//public Transform s2;
	//public Transform s3;
	//public Transform s4;
	//public GameObject g1;
	//public GameObject g2;
	//public GameObject g3;
	//public GameObject g4;
	public bool createText = false;
	public LayerMask lm;
	public GameObject textHolder;
	public GameObject boxBreathing;
	public Transform boxBreathingSpawn;
	public List<Transform> spawnPoints = new List<Transform>();
	//public List<GameObject> textObjects = new List<GameObject>();
	public List<string> phrases = new List<string>();
	public float interval = 2.0f;
	


	private void Awake() {

		lm = LayerMask.GetMask("Ground", "Objects");
	}
	private Vector3 GetYWithRaycast(Transform s) {
		RaycastHit hit;
		Vector3 rayPosition = s.position;
		rayPosition.y = 100;
		if (Physics.Raycast(rayPosition, Vector3.down, out hit, 200f, layerMask: lm)) {
			print(hit.point);
			Vector3 final = new Vector3(hit.point.x, hit.point.y + 3, hit.point.z);
			return final;

		}
		return this.transform.position;
	}

	private void SpawnSingle() {
		Vector3 new1 = GetYWithRaycast(spawnPoints[0]);
		GameObject t = Instantiate(textHolder, new1, new Quaternion(0, 0, 0, 0));
		t.GetComponent<PhraseHolder>().SetText(phrases[0]);
		spawnPoints.RemoveAt(0);
		phrases.RemoveAt(0);
		//textObjects.RemoveAt(0);
	}
	public void SpawnAll() {
		StartCoroutine(TextSpawn());
	}
	private IEnumerator TextSpawn() {
		while (spawnPoints.Count > 0) {
			SpawnSingle();
			yield return new WaitForSeconds(interval);
		}
		if (boxBreathing != null) {
			Vector3 newPos = GetYWithRaycast(boxBreathingSpawn);
			Instantiate(boxBreathing, newPos, new Quaternion(0, 0, 0, 0));
		}
	}

	private void Update() {
		if (createText == true) {
			SpawnAll();
			createText = false;
		}
	}
}
