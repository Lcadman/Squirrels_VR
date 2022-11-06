using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class SpawnText : MonoBehaviour
{
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

	public List<Transform> spawnPoints = new List<Transform>();
	public List<GameObject> textObjects = new List<GameObject>();


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

	public void spawnSingle()
	{
			Vector3 new1 = GetYWithRaycast(spawnPoints[0]);
			Instantiate(textObjects[0], new1, new Quaternion(0, 0, 0, 0));
			spawnPoints.RemoveAt(0);
			textObjects.RemoveAt(0);
	}
	public void spawnAll()
	{
		StartCoroutine(textSpawn());
	}
	public IEnumerator textSpawn()
	{
		while(spawnPoints.Count > 0)
		{
			spawnSingle();
			yield return new WaitForSeconds(4);
		}
	}

	private void Update()
	{
		if (createText == true)
		{
			spawnAll();
			createText = false;
		}
	}
}
