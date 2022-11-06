using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyController : MonoBehaviour
{
    // name desired material 
    private Material Skybox_9;

    private float Tfactor;
    public bool isNight;

    public float NightValue;
    public float DayValue;

    public float RotationSpeed;
    public float ChangeSpeed;

    // Start is called before the first frame update
    void Start()
    {

        Skybox_9 = RenderSettings.skybox;

        
    }

    // Update is called once per frame
    void Update()
    {

        Skybox_9.SetFloat("_Rotation", Skybox_9.GetFloat("_Rotation") + Time.deltaTime * RotationSpeed);

        if(isNight == true && Tfactor >= NightValue)
        {

            Tfactor -= Time.deltaTime * ChangeSpeed;

            Skybox_9.SetColor("_Tint", new Color(Tfactor, Tfactor, Tfactor, 1));
        }
        else if (isNight == false && Tfactor <= DayValue)
        {
            Tfactor += Time.deltaTime * ChangeSpeed;

            Skybox_9.SetColor("_Tint", new Color(Tfactor, Tfactor, Tfactor, 1));

        }


    }
}
