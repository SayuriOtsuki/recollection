using UnityEngine;
using System.Collections;

public class AlbumSceneManager : MonoBehaviour {

	
	public int tabacoMaxNum = 151;
	public int tabacoMinNum = 156;

	SpriteManager spriteManager;

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
		if (GUI.Button (new Rect (450, 300, 100, 50), "Tabaco")) {
			Resources.UnloadUnusedAssets();
			Debug.Log("tabaco");
			Application.LoadLevel ("tabaco");
//			spriteManager.maxNum = tabacoMaxNum;
//			spriteManager.minNum = tabacoMinNum;
		}

	}
}
