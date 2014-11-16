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


	private SpriteRenderer sRen_L;
	private SpriteRenderer sRen_M;
	private SpriteRenderer sRen_R;


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
					OnSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}

				else if(num == maxNum){
					num = minNum;
					Lnum = maxNum;
					Rnum = num + 1;
					OnSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}

				else {
				num++;
				Lnum = num - 1;
				Rnum = num + 1;
				OnSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}

			}

			 //右に動かしたら
			if(spriteMiddle.transform.position.x > moveLimitPos){

				if(num == minNum + 1){
					num--;
					Lnum = maxNum;
					Rnum = num + 1;
					OnSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}
				
				else if(num == minNum){
					num = maxNum;
					Lnum = num - 1;
					Rnum = minNum;
					OnSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}
				else{
				num --;
				Lnum = num - 1;
				Rnum = num + 1;
				OnSlide(num.ToString(), Lnum.ToString(), Rnum.ToString());
				}
				
			}

		}
		
	}

	void OnSlide(string num, string LNum, string Rnum){
		Debug.Log (Lnum + " " + num + " " + Rnum);
		spriteMiddle.transform.position = MiddleFirstPos;
		sRen_M.sprite = Resources.Load<Sprite>("Samples/sample_"+ num);
		sRen_L.sprite = Resources.Load<Sprite>("Samples/sample_"+ Lnum);
		sRen_R.sprite = Resources.Load<Sprite>("Samples/sample_"+ Rnum);
	}
	
}