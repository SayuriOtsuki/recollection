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

	void OnMoveToRight(){

		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);

		if(currentNum == maxNum){
			currentNum = minNum;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);
		}
		else{
			currentNum ++;
			
			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);
		}

	}

	void OnMoveToLeft(){

		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);

		if(currentNum == minNum){
			currentNum = maxNum;
			
			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);
		}
		else{
			currentNum --;
			
			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);
		}

	}

	void OnGUI(){

		int LButton = 40;
		int RButton = 450;
		int buttonHeight = 200;
		int buttonWidth = 100;
		int buttonTateSize = 50;

		
		if (GUI.Button (new Rect (LButton, buttonHeight, buttonWidth, buttonTateSize), "L")) {
			OnMoveToLeft();
			
		}
		if (GUI.Button (new Rect (RButton, buttonHeight, buttonWidth, buttonTateSize), "R")) {
			
			OnMoveToRight();
			
		}

		int height = 100;
		int height2 = 200;
		int width = 100;
		int tate = 50;
		int buttonFirstXPos = 150;
		int buttonXPosdif = 100;
		
		if (GUI.Button (new Rect (buttonFirstXPos, height, width, tate), "Home")) {
			Resources.UnloadUnusedAssets();
			Debug.Log("Home");
			Application.LoadLevel ("StartScene");
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif, height, width, tate), "All")) {

			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);
				
			currentNum = 1;
			int allMinNum = 1;
			int allMaxNum = 189;		

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + allMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);


			maxNum = allMaxNum;
			minNum = allMinNum;
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif*2, height, width, tate), "3rinAuto")) {

			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 1;
			int autoMinNum = 1;
			int autoMaxNum = 4;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + autoMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			maxNum = autoMaxNum;
			minNum = autoMinNum;
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif*3, height, width, tate), "Camera")) {

			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 5;
			int cameraMinNum = 5;
			int cameraMaxNum = 5;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + cameraMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			maxNum = cameraMaxNum;
			minNum = cameraMinNum;
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif*4, height, width, tate), "Dagashi")) {

			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 6;
			int dagashiMinNum = 6;
			int dagashiMaxNum = 23;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + dagashiMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);


			maxNum = dagashiMaxNum;
			minNum = dagashiMinNum;
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif*5, height, width, tate), "Food/Drink")) {

			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 24;
			int fdMinNum = 24;
			int fdMaxNum = 52;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + fdMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);


			maxNum = fdMaxNum;
			minNum = fdMinNum;
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif*6, height, width, tate), "House")) {
			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 53;
			int houseMinNum = 53;
			int houseMaxNum = 75;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + houseMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			maxNum = houseMaxNum;
			minNum = houseMinNum;
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif*7, height, width, tate), "Sign Board")) {
			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 76;
			int sbMinNum = 76;
			int sbMaxNum = 93;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + sbMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			maxNum = sbMaxNum;
			minNum = sbMinNum;
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif*8, height, width, tate), "Kitchen")) {
			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 94;
			int kitchenMinNum = 94;
			int kitchenMaxNum = 101;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + kitchenMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			maxNum = kitchenMaxNum;
			minNum = kitchenMinNum;
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif*9, height, width, tate), "Other Items")) {

			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 102;
			int oiMinNum = 102;
			int oiMaxNum = 161;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + oiMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			maxNum = oiMaxNum;
			minNum = oiMinNum;
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif*10, height, width, tate), "Post")) {
			
			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 162;
			int postMinNum = 162;
			int postMaxNum = 162;
		
			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + postMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			maxNum = postMaxNum;
			minNum = postMinNum;
		}
		
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif, height2, width, tate), "Radio")) {

			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 163;
			int radioMinNum = 163;
			int radioMaxNum = 163;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + radioMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			maxNum = radioMaxNum;
			minNum = radioMinNum;
		}
		
		
		//タバコ関連の写真だけ
		if (GUI.Button (new Rect (buttonFirstXPos + buttonXPosdif*2, height2, width, tate), "Tabaco")) {

			GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
			Destroy(currentPrefab);

			currentNum = 175;
			int tabacoMinNum = 175;
			int tabacoMaxNum = 184;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + tabacoMinNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			maxNum = tabacoMaxNum;
			minNum = tabacoMinNum;
		}

	}
}
