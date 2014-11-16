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

		LeftFirstPos = spriteLeft.transform.position;
		MiddleFirstPos = spriteMiddle.transform.position;
		RightFirstPos = spriteRight.transform.position;


	}
	
	void Update () {
		
		if(Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved){
			
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
			spriteLeft.transform.Translate(touchDeltaPosition.x * moveSpeed, 0, 0);
			spriteMiddle.transform.Translate(touchDeltaPosition.x * moveSpeed, 0, 0);
			spriteRight.transform.Translate(touchDeltaPosition.x * moveSpeed, 0, 0);
			
//			float limit_valueY = Mathf.Clamp (transform.position.y,  0.0f, 21.5f);
//			float limit_valueX = Mathf.Clamp (transform.position.x, -2.7f, 3.0f);
//			transform.position = new Vector3 (0, 0, transform.position.z);
//			
		}
		
		//ぴたっと止める
		if(Input.touchCount  > 0 && Input.GetTouch (0).phase == TouchPhase.Ended){
			Debug.Log ("Ended");
			//左に動かしたら
			if(spriteMiddle.transform.position.x < -moveLimitPos){

				spriteLeft.transform.position = LeftFirstPos;
				spriteMiddle.transform.position = MiddleFirstPos;
				spriteRight.transform.position = RightFirstPos;

			}

			 //右に動かしたら
			if(spriteMiddle.transform.position.x > moveLimitPos){
				
				spriteLeft.transform.position = LeftFirstPos;
				spriteMiddle.transform.position = MiddleFirstPos;
				spriteRight.transform.position = RightFirstPos;
				
			}

		}
		
	}
}