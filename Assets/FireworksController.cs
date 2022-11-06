using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksController : MonoBehaviour
{

	private IEnumerator fireworksCoroutine;

	private void Start() {
		fireworksCoroutine = PlayFireworks();
	}

	private IEnumerator PlayFireworks() {
		yield return new WaitForSeconds(1);
		print("worked");
	}
    // Start is called before the first frame update
    public void Play()
    {
		print("attempted");
		StartCoroutine(fireworksCoroutine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
