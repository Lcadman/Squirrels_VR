using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTo : MonoBehaviour
{
	public Transform t = null;
	public float distance = -1;

	private void Start() {
		if (t == null) {
			t = GameObject.FindGameObjectWithTag("Player").transform;
		}
	}

	// Update is called once per frame
	void Update()
    {
		distance = Vector3.Distance(transform.position, t.position);
    }
}
