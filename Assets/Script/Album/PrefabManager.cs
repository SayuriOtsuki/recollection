using UnityEngine;
using System.Collections;

public class PrefabManager : MonoBehaviour {
	public GameObject[] imageBoards;
	int currentPictureNum = -1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		int LButton = 100;
		int RButton = 800;
		int height = 300;
		int width = 100;
		int tateSize = 50;

		if (GUI.Button (new Rect (LButton, height, width, tateSize), "L")) {

			Debug.Log("L");

			currentPictureNum ++;
			int nextPictureNum = currentPictureNum + 1;
			GameObject.Destroy(imageBoards[currentPictureNum]);
			Instantiate(imageBoards[nextPictureNum],new Vector3(0,0,0),Quaternion.identity);

		}
		if (GUI.Button (new Rect (RButton, height, width, tateSize), "R")) {

			Debug.Log("R");

		}
	}
}
