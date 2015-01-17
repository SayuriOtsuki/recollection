﻿using UnityEngine;
using System.Collections;

public class ParticleManager_Smoke : MonoBehaviour {

//	public GUIText targetGUIText;
//	public GameObject cube;
	ParticleSystem smoke;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update() {

		
		if (Input.touchCount > 0)
		{
			Debug.Log ("Touch");

			Vector3 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
			Vector3 newVector = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

			Vector2 tapPoint = new Vector2(newVector.x, newVector.y);
			Collider2D colition2d = Physics2D.OverlapPoint(tapPoint);
								
				
				if (colition2d != null)
				{ 
					Debug.Log(colition2d.name);
					smoke = colition2d.GetComponent<ParticleSystem>();
					smoke.particleSystem.Play();

					
				}else{
					Debug.Log("NUll");
				}
		}
		
	}
}
