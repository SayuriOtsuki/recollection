using UnityEngine;
using System.Collections;

public class SpriteManager : MonoBehaviour {
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

		if (GUI.Button (new Rect (150, height, 100, 50), "Home")) {
			Resources.UnloadUnusedAssets();
			Debug.Log("Home");
			Application.LoadLevel ("StartScene");
		}

		if (GUI.Button (new Rect (250, height, 100, 50), "All")) {
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

		if (GUI.Button (new Rect (350, height, 100, 50), "3rinAuto")) {
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


		//タバコ関連の写真だけ
		if (GUI.Button (new Rect (350, height2, 100, 50), "Tabaco")) {
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