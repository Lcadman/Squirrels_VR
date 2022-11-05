using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTo : MonoBehaviour
{
	public Transform t;
	public float distance = -1;


    // Update is called once per frame
    void Update()
    {
		distance = Vector3.Distance(transform.position, t.position);
    }
}
