using UnityEngine;
using System.Collections;

public class RadioManager : MonoBehaviour {
	
	GameObject music1;
	GameObject music2;
	GameObject music3;


	// Use this for initialization
	void Start () {
	
		music1 = GameObject.Find ("music1");
		music2 = GameObject.Find ("music2");
		music3 = GameObject.Find ("music3");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Ended){
				Debug.Log ("Touch");
				
				Vector3 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
				Vector3 newVector = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
				
				Vector2 tapPoint = new Vector2(newVector.x, newVector.y);
				Collider2D colition2d = Physics2D.OverlapPoint(tapPoint);
				
				
				if (colition2d == music1){ 

					Debug.Log(colition2d.name);
					
				}else if(colition2d == music2){

					Debug.Log(colition2d.name);

				}else if(colition2d == music2){

					Debug.Log(colition2d.name);

				}
			}
		}
	}
}
