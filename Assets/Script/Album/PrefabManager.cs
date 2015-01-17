using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PrefabManager : MonoBehaviour {

	int currentNum = 1;
	int displayCurrentNum = 1;
	public int displayMaxNum = 80;
	public int minNum = 1;
	public int maxNum = 80;

//	public GameObject pictureNumber;
	public Text numberText;

	// Use this for initialization
	void Start () {

		numberText = numberText.GetComponent<Text>();
		currentNum = minNum;
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	public void OnMoveToRight(){
		//前のプレハブ削除
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);

		//プレハブ作成
		if(currentNum == maxNum){
			currentNum = minNum;
		}
		else{
			currentNum ++; 
		}
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + currentNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);

		//枚数表示用
		if(displayCurrentNum == displayMaxNum){
			displayCurrentNum = 1;
		}else{
			displayCurrentNum ++;
		}
			

		numberText.text = displayCurrentNum + " / " + displayMaxNum;


	}

	public void OnMoveToLeft(){
		//前のプレハブ削除
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);

		Debug.Log ("DestroyLeft");
		Debug.Log ("currentNum = "+ currentNum);
		Debug.Log ("minNum = "+ minNum);
		//プレハブ作成
		if(currentNum == minNum){
			currentNum = maxNum;
		

		}
		else{
			currentNum --;
		
		}

		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + currentNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);

		//枚数表示用
		if(displayCurrentNum == 1){
			displayCurrentNum = displayMaxNum;
		}else{
			displayCurrentNum --;
		}	
		numberText.text = displayCurrentNum + " / " + displayMaxNum;


	}

	public void HomeButton(){
		Resources.UnloadUnusedAssets();
		Debug.Log("Home");
		Application.LoadLevel ("StartScene");

	}

	public void All(){
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		
		currentNum = 1;
		int allMinNum = 1;
		int allMaxNum = 80;		
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + allMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		
		maxNum = allMaxNum;
		minNum = allMinNum;

		displayCurrentNum = 1;
		displayMaxNum = allMaxNum - allMinNum + 1;
		numberText.text = displayCurrentNum + " / " + displayMaxNum;

	}

	
	public void Home(){
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
			
		int homeMinNum = 1;
		currentNum = homeMinNum;
		int homeMaxNum = 15;
			
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + homeMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
			
		maxNum = homeMaxNum;
		minNum = homeMinNum;

		displayCurrentNum = 1;
		displayMaxNum = homeMaxNum - homeMinNum + 1;
		numberText.text = displayCurrentNum + " / " + displayMaxNum;

	}
	public void Curry(){
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);

		int curryMinNum = 16;
		currentNum = curryMinNum;
		int curryMaxNum = 23;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + curryMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		maxNum = curryMaxNum;
		minNum = curryMinNum;

		displayCurrentNum = 1;
		displayMaxNum = curryMaxNum - curryMinNum + 1;
		numberText.text = displayCurrentNum + " / " + displayMaxNum;

	}

	public void Kitchen(){
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		
		
		int kitchenMinNum = 24;
		currentNum = kitchenMinNum;
		int kitchenMaxNum = 28;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + kitchenMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		maxNum = kitchenMaxNum;
		minNum = kitchenMinNum;
		
		displayCurrentNum = 1;
		displayMaxNum = kitchenMaxNum - kitchenMinNum + 1;
		numberText.text = displayCurrentNum + " / " + displayMaxNum;
		
	}

	public void Nougu(){
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		
		
		int nouguMinNum = 29;
		currentNum = nouguMinNum;
		int nouguMaxNum = 32;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + nouguMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		
		maxNum = nouguMaxNum;
		minNum = nouguMinNum;
		
		displayCurrentNum = 1;
		displayMaxNum = nouguMaxNum - nouguMinNum + 1;
		numberText.text = displayCurrentNum + " / " + displayMaxNum;
		
		
	}

	public void TownScene(){
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		
		
		int tsMinNum = 33;
		currentNum = tsMinNum;
		int tsMaxNum = 44;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + tsMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		maxNum = tsMaxNum;
		minNum = tsMinNum;
		
		displayCurrentNum = 1;
		displayMaxNum = tsMaxNum - tsMinNum + 1;
		numberText.text = displayCurrentNum + " / " + displayMaxNum;
		
		
	}

	public void Dagashi(){
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		

		int dagashiMinNum = 45;
		currentNum = dagashiMinNum;
		int dagashiMaxNum = 61;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + dagashiMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		
		maxNum = dagashiMaxNum;
		minNum = dagashiMinNum;

		displayCurrentNum = 1;
		displayMaxNum = dagashiMaxNum - dagashiMinNum + 1;
		numberText.text = displayCurrentNum + " / " + displayMaxNum;

	}



	public void Tabaco(){
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		

		int tabacoMinNum = 62;
		currentNum = tabacoMinNum;
		int tabacoMaxNum = 70;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + tabacoMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		maxNum = tabacoMaxNum;
		minNum = tabacoMinNum;

		displayCurrentNum = 1;
		displayMaxNum = tabacoMaxNum - tabacoMinNum + 1;
		numberText.text = displayCurrentNum + " / " + displayMaxNum;


	}
	

	public void Horo(){
		GameObject currentPrefab = GameObject.Find("recol_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		

		int horoMinNum = 71;
		currentNum = horoMinNum;
		int horoMaxNum = 80;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/recol_" + horoMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		maxNum = horoMaxNum;
		minNum = horoMinNum;
		
		displayCurrentNum = 1;
		displayMaxNum = horoMaxNum - horoMinNum + 1;
		numberText.text = displayCurrentNum + " / " + displayMaxNum;
		
	}
	

}
