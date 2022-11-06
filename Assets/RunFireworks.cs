using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunFireworks : MonoBehaviour
{
    public GameObject[] fireworks;
    public float timeRemaining = 350;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fireworkDisplay());
    }


    private IEnumerator fireworkDisplay()
    {
        while (timeRemaining > 0)
        {
            int i = 5;
            while (i > 0)
            {
                float random_wait = UnityEngine.Random.Range(0f, 2f);
                int prefabIndex = UnityEngine.Random.Range(3, 5);
                yield return new WaitForSeconds(random_wait);
                Instantiate(fireworks[prefabIndex], transform.position, Quaternion.identity);
                i -= 1;
            }
            timeRemaining -= 1;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
