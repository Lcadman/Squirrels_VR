using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HP.Omnicept.Unity;

public class PrintHeartrate : MonoBehaviour
{
    private GliaBehaviour GlIA;

    // Start is called before the first frame update
    void Start()
    {
        GlIA = GetComponent<GliaBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        var heartrate = GlIA.GetLastHeartRate();
        Debug.Log(heartrate);
    }
}
