using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BreathingText : MonoBehaviour {
	public List<string> phrases = new List<string>();
	public float interval = 4.0f;
	public TextMeshProUGUI textGUI;
	// Start is called before the first frame update

	private void Start() {
		StartCoroutine(controlText());
	}
	private IEnumerator controlText() {
		{
			int index = 0;
			while (true) {
				textGUI.text = phrases[index];
				yield return new WaitForSeconds(interval);
				index++;
				if (index >= phrases.Count) {
					index = 0;
				}
			}
		}
	}

	// Update is called once per frame
	void Update() {

	}
}
