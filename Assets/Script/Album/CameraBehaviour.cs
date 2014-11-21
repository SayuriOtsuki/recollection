using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {
	public float zMin;
	public float zMax = -2.0f;
	public float pinchRate = 1.0f;
	public GameObject mCamera;

	private float backDist = 0.0f;

	void Start(){
		zMin = mCamera.transform.position.z;
	}

	void Update(){
		if (Input.touchCount == 2) {
			Touch t1 = Input.GetTouch(0);
			Touch t2 = Input.GetTouch(1);
			//2点タッチ開始時の距離を記憶
			if(t2.phase == TouchPhase.Began){
				backDist = Vector2.Distance(t1.position, t2.position);
			}
			//ピンチイン・アウト
			else if (t1.phase == TouchPhase.Moved && t2.phase == TouchPhase.Moved){
				float newDist = Vector2.Distance(t1.position, t2.position);
				float transZ = (newDist - backDist) / pinchRate;
				
				if(transZ != 0){
					
					
					Vector3 newPos = mCamera.transform.position;
					newPos.z += transZ;
					//transform.camera.orthographicSize += transZ; 
					
					//zMin～zMaxの範囲内のみ.
					if(zMin <= newPos.z && newPos.z <= zMax){
						Debug.Log ("newPos.z=" + newPos.z);
						mCamera.transform.position = newPos;
						backDist = newDist;
					}
				}
				
			}
		}
	}
}