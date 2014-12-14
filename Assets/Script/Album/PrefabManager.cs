using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PrefabManager : MonoBehaviour {

	int currentNum = 1;
	int displayCurrentNum;
	int displayMaxNum;
	public int minNum = 1;
	public int maxNum = 5;

	GameObject pictureNumber;
	public Text numberText;

	// Use this for initialization
	void Start () {
		pictureNumber = GameObject.Find ("pictureNumber");
		numberText = pictureNumber.GetComponent<Text>();
		currentNum = minNum;
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	public void OnMoveToRight(){

		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);

		if(currentNum == maxNum){
			currentNum = minNum;

			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			numberText.text = currentNum + " / " + maxNum;


		}
		else{
			currentNum ++;
			
			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			numberText.text = currentNum + " / " + maxNum;

		}

	}

	public void OnMoveToLeft(){

		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);

		if(currentNum == minNum){
			currentNum = maxNum;
			
			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			numberText.text = currentNum + " / " + maxNum;


		}
		else{
			currentNum --;
			
			GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + currentNum.ToString());
			Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
			Debug.Log ("currentNum = "+ currentNum);

			numberText.text = currentNum + " / " + maxNum;
		}

	}

	public void HomeButton(){
		Resources.UnloadUnusedAssets();
		Debug.Log("Home");
		Application.LoadLevel ("StartScene");

	}

	public void All(){
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

	
	public void SanrinAuto(){
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
	public void Camera(){
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
	public void Dagashi(){
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

	public void DrinkFood(){
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

	public void HomeScene(){
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

	public void SignBoard(){
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

	public void Kitchen(){
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

	public void Others(){
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

	public void Post(){
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

	public void Radio(){
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

	public void Town(){
		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		
		currentNum = 164;
		int townMinNum = 164;
		int townMaxNum = 172;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + townMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		maxNum = townMaxNum;
		minNum = townMinNum;

	}

	public void School(){
		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		
		currentNum = 173;
		int schoolMinNum = 173;
		int schoolMaxNum = 174;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + schoolMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		maxNum = schoolMaxNum;
		minNum = schoolMinNum;

	}

	public void Tabaco(){
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

	public void Phone(){
		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		
		currentNum = 185;
		int phoneMinNum = 185;
		int phoneMaxNum = 187;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + phoneMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		maxNum = phoneMaxNum;
		minNum = phoneMinNum;

	}
	public void TV(){
		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		
		currentNum = 188;
		int tvMinNum = 188;
		int tvMaxNum = 188;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + tvMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		maxNum = tvMaxNum;
		minNum = tvMinNum;

	}

	public void Barbar(){
		GameObject currentPrefab = GameObject.Find("sample_" + currentNum.ToString() + "(Clone)");
		Destroy(currentPrefab);
		
		currentNum = 189;
		int barbarMinNum = 189;
		int barbarMaxNum = 189;
		
		GameObject nextPrefab = (GameObject)Resources.Load ("Prefab/Album/sample_" + barbarMinNum.ToString());
		Instantiate(nextPrefab, new Vector3(0,0,0), Quaternion.identity);
		Debug.Log ("currentNum = "+ currentNum);
		
		maxNum = barbarMaxNum;
		minNum = barbarMinNum;

	}

}
