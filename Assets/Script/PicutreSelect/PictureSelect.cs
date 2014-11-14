using UnityEngine;
using System.Collections;

public class PictureSelect : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.touchCount == 1 && Input.GetTouch (0).phase == TouchPhase.Ended) {
			Debug.Log("Touched");

			Touch touch = Input.GetTouch(0);

			Vector3 newVector = Camera.main.ScreenToWorldPoint( new Vector3( touch.position.x, touch.position.y, Input.mousePosition.z));
			
			Vector2 tapPoint = new Vector2(newVector.x, newVector.y);
			Collider2D colition2d = Physics2D.OverlapPoint(tapPoint);
			
			if(colition2d){
				Debug.Log ("This is = "+ colition2d.name);
				colition2d.transform.localScale = new Vector3(1,1,1);

			}
				
				

		}
	
	}
}
