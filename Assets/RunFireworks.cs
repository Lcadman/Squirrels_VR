using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunFireworks : MonoBehaviour
{
    public GameObject[] fireworks;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fireworkDisplay());
    }


    private IEnumerator fireworkDisplay()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[0]);
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[0]);
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[0]);
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[0]);
            yield return new WaitForSeconds(1);
            Instantiate(fireworks[0]);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
