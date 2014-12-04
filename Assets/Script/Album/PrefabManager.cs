using UnityEngine;
using System.Collections;

public class PrefabManager : MonoBehaviour {

	int currentNum = 1;
	public int minNum = 1;
	public int maxNum = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		int LButton = 40;
		int RButton = 450;
		int height = 200;
		int width = 100;
		int tateSize = 50;

		if (GUI.Button (new Rect (LButton, height, width, tateSize), "L")) {
			OnMoveToLeft();

		}
		if (GUI.Button (new Rect (RButton, height, width, tateSize), "R")) {

			OnMoveToRight();

		}
	}

	void OnMoveToRight(){

		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);

		if(currentNum == maxNum){
			currentNum = minNum;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log (currentNum);
		}
		else{
			currentNum ++;
			
			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log (currentNum);
		}

	}

	void OnMoveToLeft(){

		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);

		if(currentNum == minNum){
			currentNum = maxNum;
			
			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log (currentNum);
		}
		else{
			currentNum --;
			
			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log (currentNum);
		}

	}
}
