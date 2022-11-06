using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fade : MonoBehaviour
{
	public List<Renderer> renderers = new List<Renderer>();
	public IEnumerator FadeOverSeconds(float seconds)
	{

		foreach (var renderer in renderers)
		{
			Color newColor = renderer.material.color;
			newColor.a = 0.3f;
			renderer.material.SetColor("_Color", newColor);
			while (renderer.material.color.a > 0)
			{
				Color objectColor = renderer.material.color;
				float fadeAmount = objectColor.a - (Time.deltaTime / seconds);
				objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
				renderer.material.color = objectColor;
				yield return null;
			}
			
		}


		foreach (var renderer in renderers)
		{
			renderer.gameObject.SetActive(false);
		}
	}
	public void StartFade(float seconds)
	{
		StartCoroutine(FadeOverSeconds(seconds));
	}
}
