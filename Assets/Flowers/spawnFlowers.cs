using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class spawnFlowers : MonoBehaviour
{
	public bool createText = false;
	public LayerMask lm;
	public List<GameObject> flower_objects = new List<GameObject>();
	public float interval = 2.0f;
	public Vector3 minPosition;
	public Vector3 maxPosition;

	private void Start()
	{
		SpawnAll();
	}

	private void Awake()
	{

		lm = LayerMask.GetMask("Ground", "Objects");
	}
	private Vector3 GetYWithRaycast(Vector3 s)
	{
		RaycastHit hit;
		Vector3 rayPosition = s;
		//Debug.Log("rayPosition: " + rayPosition);
		//Debug.Log("rayPosition100: " + rayPosition);
		if (Physics.Raycast(rayPosition, Vector3.down, out hit, 200f, layerMask: lm))
		{
			//print(hit.point);
			Vector3 final = new Vector3(hit.point.x, hit.point.y, hit.point.z);
			GameObject flow = Instantiate(flower_objects[0], final, Quaternion.identity);
			//flow.transform.Rotate(0f, 0f, Random.Range(0, 100));
			//Debug.Log("rayPosition3: " + rayPosition);
			return final;

		}
		return this.transform.position;
	}

	private void SpawnSingle()
	{
		Vector3 randomPosition = new Vector3(
			Random.Range(-55, 55),
			100f,
			Random.Range(-35, 45)
		);
		//Debug.Log("rand: " + randomPosition);
		Vector3 new1 = GetYWithRaycast(randomPosition);
		//Debug.Log("new1: " + new1);
	}
	public void SpawnAll()
	{
		StartCoroutine(TextSpawn());
	}
	private IEnumerator TextSpawn()
	{
		int i = 0;
		while (i < 100)
		{
			i += 1;
			SpawnSingle();
			yield return null;
		}
	}

	private void Update()
	{
	}
}
