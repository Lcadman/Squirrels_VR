using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class SpawnText : MonoBehaviour
{
	public Transform s1;
	public Transform s2;
	public Transform s3;
	public Transform s4;
	public GameObject g1;
	public GameObject g2;
	public GameObject g3;
	public GameObject g4;
	public bool createText = false;
	public LayerMask lm;

	private void Awake()
	{
		lm = LayerMask.GetMask("Ground");
	}
	private Vector3 GetYWithRaycast(Transform s)
	{
		RaycastHit hit;
		Vector3 rayPosition = s.position;
		rayPosition.y = 100;
		if (Physics.Raycast(rayPosition, Vector3.down, out hit, 200f, layerMask: lm))
		{
			print(hit.point);
			Vector3 final = new Vector3(hit.point.x, hit.point.y + 1, hit.point.z);
			return final;

		}
		return this.transform.position;
	}

	public void spawnText()
	{
		Vector3 new1 = GetYWithRaycast(s1);
		Vector3 new2 = GetYWithRaycast(s2);
		Vector3 new3 = GetYWithRaycast(s3);
		Vector3 new4 = GetYWithRaycast(s4);
		Instantiate(g1, new1, new Quaternion(0, 0, 0, 0));
		Instantiate(g2, new2, new Quaternion(0, 0, 0, 0));
		Instantiate(g3, new3, new Quaternion(0, 0, 0, 0));
		Instantiate(g4, new4, new Quaternion(0, 0, 0, 0));

	}

	private void Update()
	{
		if (createText == true)
		{
			spawnText();
			createText = false;
		}
	}
}
