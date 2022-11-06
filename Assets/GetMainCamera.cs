using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMainCamera : MonoBehaviour
{
	private Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
		GetComponent<Canvas>().worldCamera = Camera.main;
		mainCam = Camera.main;
	}

	

	// Update is called once per frame
	void Update()
	{
		//transform.LookAt(mainCam.transform);

		transform.LookAt(2 * transform.position - mainCam.transform.position);
	}
}

  

