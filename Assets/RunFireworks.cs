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
            int prefabIndex = UnityEngine.Random.Range(3, 5);
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[prefabIndex]);
            prefabIndex = UnityEngine.Random.Range(0, 2);
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[prefabIndex]);
            prefabIndex = UnityEngine.Random.Range(3, 5);
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[prefabIndex]);
            prefabIndex = UnityEngine.Random.Range(0, 2);
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[prefabIndex]);
            prefabIndex = UnityEngine.Random.Range(3, 5);
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[prefabIndex]);
            prefabIndex = UnityEngine.Random.Range(0, 3);
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[prefabIndex]);
            timeRemaining -= 6;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
