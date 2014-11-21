using UnityEngine;
using System.Collections;

public class AlbunSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (300, 300, 100, 50), "Home")) {
			Application.LoadLevel ("StartScene");
		}
	}
}
