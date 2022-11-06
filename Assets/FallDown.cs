using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
	public float speed = 1.0f;


	
	public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time)
	{
		float i = 0.0f;
		float rate = (1.0f / time) * speed;
		while (i < 1.0f)
		{
			i += Time.deltaTime * rate;
			this.transform.position = Vector3.Lerp(a, b, i);
			yield
			return null;
		}
	}
	// Start is called before the first frame update
	void Start()
    {
		StartCoroutine(RepeatLerp(new Vector3(transform.position.x, transform.position.y + 10, transform.position.z), transform.position , 3.0f));
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
