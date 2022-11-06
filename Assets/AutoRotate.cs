using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
	public float length = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		float speed = 1.0f / length;
		transform.Rotate(0, 0, -speed * 360 * Time.deltaTime);
	}
}
