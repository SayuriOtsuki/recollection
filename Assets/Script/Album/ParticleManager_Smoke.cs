using UnityEngine;
using System.Collections;

public class ParticleManager_Smoke : MonoBehaviour {

//	public GUIText targetGUIText;
//	public GameObject cube;
	GameObject smoke;
	
	// Use this for initialization
	void Start () {
		smoke = GameObject.Find ("smoke");
	}
	
	// Update is called once per frame
	void Update() {

		
		if (Input.touchCount > 0)
		{
			
			Touch touch = Input.GetTouch(0);
			
			Vector2 touchingPos = new Vector2();
			touchingPos = Camera.main.ScreenToWorldPoint(touch.position);
			Collider2D colition2d = Physics2D.OverlapPoint(touchingPos);
								
				
				if (colition2d != null)
				{ 
					Debug.Log(colition2d.name);
					smoke.particleSystem.Play();
//
//					colition2d.rigidbody2D.velocity = Vector2.zero;
//					colition2d.rigidbody2D.angularVelocity = 0f;
//					
//					Vector2 objectPos = colition2d.rigidbody2D.transform.position;
//					Vector2  direction = touchingPos - objectPos;
//					direction *= cube.rigidbody2D.mass * 1000;
//					colition2d.rigidbody2D.velocity *= 0.95f;
//					
//					colition2d.rigidbody2D.AddForceAtPosition(direction, objectPos);
//					
					
				}
		}
		
	}
}
