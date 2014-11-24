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
//			Resources.UnloadUnusedAssets();
//			Debug.Log("tabaco");
//			Application.LoadLevel ("tabaco");
			int tabacoSpriteRNum = tabacoMinNum + 1;

			spriteManager.sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ tabacoMaxNum.ToString());
			spriteManager.sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ tabacoMinNum.ToString());
			spriteManager.sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ tabacoSpriteRNum.ToString());
			spriteManager.maxNum = tabacoMaxNum;
			spriteManager.minNum = tabacoMinNum;
		}

	}
}
