using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TouchingPlayer : MonoBehaviour
{
	public UnityEvent touchEvent;
	public bool touching;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}


	private void OnTriggerEnter(Collider other)
	{
		//print("hit");
		//print(other.gameObject.tag);
		if (other.gameObject.tag == "Player")
		{
			touching = true;
			if (touchEvent != null)
			{
				touchEvent.Invoke();
			}
			//startFireworks.Invoke();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			touching = false;
		}
	}

}
