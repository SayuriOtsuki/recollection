using UnityEngine;
using System.Collections;

public class SpriteManagerBefore : MonoBehaviour {
	public float moveSpeed = 0.02f;
	public GameObject spriteLeft;
	public GameObject spriteMiddle;
	public GameObject spriteRight;
	public int num = 2;
	public int maxNum = 5;
	public int minNum = 1;

	int Lnum;
	int Rnum;


	public SpriteRenderer sRen_L;
	public SpriteRenderer sRen_M;
	public SpriteRenderer sRen_R;


	Vector3 LeftFirstPos;
	Vector3 MiddleFirstPos;
	Vector3 RightFirstPos;

	int moveLimitPos = 7;
	

	void Start () {

		MiddleFirstPos = spriteMiddle.transform.position;


		sRen_L = spriteLeft.GetComponent<SpriteRenderer> ();
		sRen_M = spriteMiddle.GetComponent<SpriteRenderer> ();
		sRen_R = spriteRight.GetComponent<SpriteRenderer> ();

		//Middleのスプライトのナンバーで考えたいためmax - 1をする

	}
	
	void Update () {

		//タッチによる移動
		if(Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved){
			
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			spriteMiddle.transform.Translate(touchDeltaPosition.x * moveSpeed, 0, 0);

//			float limitPosX = Mathf.Clamp (spriteMiddle.transform.position.x, -13.0f, 13.0f);
//			spriteMiddle.transform.position = new Vector3 (limitPosX, 0, 0);
		}
		
		//ぴたっと止める
		if(Input.touchCount  > 0 && Input.GetTouch (0).phase == TouchPhase.Ended){

			//左に動かしたら
			if(spriteMiddle.transform.position.x < -moveLimitPos){

				if(num == maxNum - 1){
					num++;
					Lnum = num - 1;
					Rnum = minNum;
					OnLeftSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}

				else if(num == maxNum){
					num = minNum;
					Lnum = maxNum;
					Rnum = num + 1;
					OnLeftSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}

				else {
					num++;
					Lnum = num - 1;
					Rnum = num + 1;
					OnLeftSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}

			}

			 //右に動かしたら
			if(spriteMiddle.transform.position.x > moveLimitPos){

				if(num == minNum + 1){
					num--;
					Lnum = maxNum;
					Rnum = num + 1;
					OnRightSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}
				
				else if(num == minNum){
					num = maxNum;
					Lnum = num - 1;
					Rnum = minNum;
					OnRightSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}
				else{
					num --;
					Lnum = num - 1;
					Rnum = num + 1;
					OnRightSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}
				
			}

			//範囲を超えなかったら動かさない
			else{
				spriteMiddle.transform.position = MiddleFirstPos;
			}

		}
		
	}

	void OnRightSlide(string num, string LNum, string Rnum){
		Debug.Log (Lnum + " " + num + " " + Rnum);
		spriteMiddle.transform.position = MiddleFirstPos;
		sRen_R.sprite = sRen_M.sprite;
		sRen_M.sprite = sRen_L.sprite;
		sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ Lnum);
	}

	void OnLeftSlide(string num, string LNum, string Rnum){
		Debug.Log (Lnum + " " + num + " " + Rnum);
		spriteMiddle.transform.position = MiddleFirstPos;
		sRen_L.sprite = sRen_M.sprite;
		sRen_M.sprite = sRen_R.sprite;
		sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ Rnum);
	}


	void OnGUI(){

		int height = 100;
		int height2 = 200;
		int width = 100;
		int tate = 50;

		if (GUI.Button (new Rect (150, height, width, tate), "Home")) {
			Resources.UnloadUnusedAssets();
			Debug.Log("Home");
			Application.LoadLevel ("StartScene");
		}

		if (GUI.Button (new Rect (250, height, width, tate), "All")) {
			num = 1;
			int allMinNum = 1;
			int allMaxNum = 189;
			
			int allSpriteRNum = allMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ allMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ allMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ allSpriteRNum.ToString());
			maxNum = allMaxNum;
			minNum = allMinNum;
		}

		if (GUI.Button (new Rect (350, height, width, tate), "3rinAuto")) {
			num = 1;
			int autoMinNum = 1;
			int autoMaxNum = 4;
			
			int autoSpriteRNum = autoMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ autoMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ autoMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ autoSpriteRNum.ToString());
			maxNum = autoMaxNum;
			minNum = autoMinNum;
		}

		if (GUI.Button (new Rect (450, height, width, tate), "Camera")) {
			num = 5;
			int cameraMinNum = 5;
			int cameraMaxNum = 5;
			
			int cameraSpriteRNum = cameraMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ cameraMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ cameraMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ cameraSpriteRNum.ToString());
			maxNum = cameraMaxNum;
			minNum = cameraMinNum;
		}

		if (GUI.Button (new Rect (550, height, width, tate), "Dagashi")) {
			num = 6;
			int dagashiMinNum = 6;
			int dagashiMaxNum = 23;
			
			int dagashiSpriteRNum = dagashiMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ dagashiMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ dagashiMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ dagashiSpriteRNum.ToString());
			maxNum = dagashiMaxNum;
			minNum = dagashiMinNum;
		}

		if (GUI.Button (new Rect (650, height, width, tate), "Food/Drink")) {
			num = 24;
			int fdMinNum = 24;
			int fdMaxNum = 52;
			
			int fdSpriteRNum = fdMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ fdMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ fdMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ fdSpriteRNum.ToString());
			maxNum = fdMaxNum;
			minNum = fdMinNum;
		}

		if (GUI.Button (new Rect (750, height, width, tate), "House")) {
			num = 53;
			int houseMinNum = 53;
			int houseMaxNum = 75;
			
			int houseSpriteRNum = houseMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ houseMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ houseMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ houseSpriteRNum.ToString());
			maxNum = houseMaxNum;
			minNum = houseMinNum;
		}

		if (GUI.Button (new Rect (850, height, width, tate), "Sign Board")) {
			num = 76;
			int sbMinNum = 76;
			int sbMaxNum = 93;
			
			int sbSpriteRNum = sbMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ sbMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ sbMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ sbSpriteRNum.ToString());
			maxNum = sbMaxNum;
			minNum = sbMinNum;
		}

		if (GUI.Button (new Rect (950, height, width, tate), "Kitchen")) {
			num = 94;
			int kitchenMinNum = 94;
			int kitchenMaxNum = 101;
			
			int kitchenSpriteRNum = kitchenMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ kitchenMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ kitchenMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ kitchenSpriteRNum.ToString());
			maxNum = kitchenMaxNum;
			minNum = kitchenMinNum;
		}

		if (GUI.Button (new Rect (1050, height, width, tate), "Other Items")) {
			num = 102;
			int oiMinNum = 102;
			int oiMaxNum = 161;
			
			int oiSpriteRNum = oiMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ oiMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ oiMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ oiSpriteRNum.ToString());
			maxNum = oiMaxNum;
			minNum = oiMinNum;
		}

		if (GUI.Button (new Rect (1150, height, width, tate), "Post")) {
			num = 162;
			int postMinNum = 162;
			int postMaxNum = 162;
			
			int postSpriteRNum = postMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ postMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ postMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ postSpriteRNum.ToString());
			maxNum = postMaxNum;
			minNum = postMinNum;
		}

		if (GUI.Button (new Rect (1150, height, width, tate), "Radio")) {
			num = 162;
			int radioMinNum = 162;
			int radioMaxNum = 162;
			
			int radioSpriteRNum = radioMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ radioMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ radioMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ radioSpriteRNum.ToString());
			maxNum = radioMaxNum;
			minNum = radioMinNum;
		}


		//タバコ関連の写真だけ
		if (GUI.Button (new Rect (350, height2, width, tate), "Tabaco")) {
			num = 175;
			int tabacoMinNum = 175;
			int tabacoMaxNum = 184;

			int tabacoSpriteRNum = tabacoMinNum + 1;
			
			sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ tabacoMaxNum.ToString());
			sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ tabacoMinNum.ToString());
			sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ tabacoSpriteRNum.ToString());
			maxNum = tabacoMaxNum;
			minNum = tabacoMinNum;
		}
		
	}
	
}