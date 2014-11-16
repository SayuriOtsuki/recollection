using UnityEngine;
using System.Collections;

public class SpriteManager : MonoBehaviour {
	public float moveSpeed = 0.02f;
	public GameObject spriteLeft;
	public GameObject spriteMiddle;
	public GameObject spriteRight;


	//private SpriteRenderer spriteRenderer;


	Vector3 LeftFirstPos;
	Vector3 MiddleFirstPos;
	Vector3 RightFirstPos;

	int moveLimitPos = 7;
	

	void Start () {

		MiddleFirstPos = spriteMiddle.transform.position;

	}
	
	void Update () {
		
		if(Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved){
			
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			spriteMiddle.transform.Translate(touchDeltaPosition.x * moveSpeed, 0, 0);

			float limitPosX = Mathf.Clamp (spriteMiddle.transform.position.x, -13.0f, 13.0f);
			spriteMiddle.transform.position = new Vector3 (limitPosX, 0, 0);
		}
		
		//ぴたっと止める
		if(Input.touchCount  > 0 && Input.GetTouch (0).phase == TouchPhase.Ended){
			//左に動かしたら
			if(spriteMiddle.transform.position.x < -moveLimitPos){

				OnMoveToLeft();

			}

			 //右に動かしたら
			if(spriteMiddle.transform.position.x > moveLimitPos){

				OnMoveToRight();
	
				
			}

		}
		
	}

	void OnMoveToLeft(){
		spriteMiddle.transform.position = MiddleFirstPos;
	}

	void OnMoveToRight(){
		spriteMiddle.transform.position = MiddleFirstPos;

	}
}