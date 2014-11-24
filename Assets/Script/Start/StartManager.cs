using UnityEngine;
using System.Collections;

public class StartManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (100, 100, 100, 50), "Album")) {
			Application.LoadLevel ("Album");
		}
		if (GUI.Button (new Rect ( 300, 100, 100, 50), "Tabaco")) {
			Application.LoadLevel ("tabaco");
		}
	}
}
