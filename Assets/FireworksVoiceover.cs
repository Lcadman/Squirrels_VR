using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksVoiceover : MonoBehaviour
{
	public float delay = 5.0f;
	public SpawnText sp;
	public IEnumerator StartVoiceover()
	{
		{
			yield return new WaitForSeconds(delay);
			GetComponent<AudioSource>().Play();
			sp.SpawnAll();
		}
	}

	public void StartVoice()
	{
		{
			StartCoroutine(StartVoiceover());
		}
	}
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
}
