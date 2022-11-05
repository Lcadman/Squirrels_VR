using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TouchingPlayer : MonoBehaviour
{
	public UnityEvent startFireworks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	private void OnTriggerEnter(Collider other) {
		print("hit");
		print(other.gameObject.tag);
		if (other.gameObject.tag == "Player") {
			startFireworks.Invoke();
		}
	}
	
}
