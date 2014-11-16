using UnityEngine;
using System.Collections;

public class SpriteManager : MonoBehaviour {
	public float moveSpeed = 0.08f;
	public GameObject spriteLeft;
	public GameObject spriteMiddle;
	public GameObject spriteRight;


	//private SpriteRenderer spriteRenderer;


	Vector3 LeftFirstPos;
	Vector3 MiddleFirstPos;
	Vector3 RightFirstPos;
	

	void Start () {

		LeftFirstPos = spriteLeft.transform.position;
		MiddleFirstPos = spriteMiddle.transform.position;
		RightFirstPos = spriteRight.transform.position;


	}
	
	void Update () {
		
		if(Input.touchCount > 1 && Input.GetTouch (0).phase == TouchPhase.Moved){
			
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
		if(Input.touchCount  > 1 && Input.GetTouch (0).phase == TouchPhase.Ended){
			
			//1
			if(comaFirst.transform.position.y < 5.0f){

				comaPos = comaDif*0 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaPos, comaFirstZ);

			}
			
			//2
			if(comaFirst.transform.position.y >= 5.0f && comaFirst.transform.position.y  < 11.3f){
			
				comaPos = comaDif*1 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaPos, comaFirstZ);

			}
			
			//3
			if(comaFirst.transform.position.y >= 11.3f && comaFirst.transform.position.y < 19.8f){
				comaPos = comaDif*2 + comaFirstY;
				comaFirst.transform.position = new Vector3(comaFirstX, comaPos, comaFirstZ);
				

			}
			
			
		}
		
	}
}