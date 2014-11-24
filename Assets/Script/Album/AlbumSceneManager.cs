using UnityEngine;
using System.Collections;

public class AlbumSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		if (GUI.Button (new Rect (300, 300, 100, 50), "Home")) {
			Resources.UnloadUnusedAssets();
			Debug.Log("Home");
			Application.LoadLevel ("StartScene");
		}
		if (GUI.Button (new Rect (400, 300, 100, 50), "Tabaco")) {
			Resources.UnloadUnusedAssets();
			Debug.Log("tabaco");
			Application.LoadLevel ("tabaco");
		}

	}
}
