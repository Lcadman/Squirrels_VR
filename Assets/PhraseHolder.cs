using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PhraseHolder : MonoBehaviour
{
	public string phrase;
	public TextMeshProUGUI textMesh;
	
    // Start is called before the first frame update
    void Start()
    {
		textMesh.text = phrase;
	}

	public void SetText(string s) {
		phrase = s;
		textMesh.text = s;
	}
}
