using UnityEngine;
using System.Collections;

public class RadioManager : MonoBehaviour {
	
	GameObject music1;
	GameObject music2;
	GameObject music3;
	AudioSource audio1;
	AudioSource audio2;
	AudioSource audio3;



	// Use this for initialization
	void Start () {
	
		music1 = GameObject.Find ("music1");
		music2 = GameObject.Find ("music2");
		music3 = GameObject.Find ("music3");

		audio1 = music1.GetComponent<AudioSource> ();
		audio2 = music2.GetComponent<AudioSource> ();
		audio3 = music3.GetComponent<AudioSource> ();
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
				
				
				if (colition2d.name == "music1"){ 

					Debug.Log(colition2d.name);
					audio1.Play();
					audio2.Stop();
					audio3.Stop();

				}else if(colition2d.name == "music2"){

					Debug.Log(colition2d.name);
					audio1.Stop();
					audio2.Play();
					audio3.Stop();

				}else if(colition2d.name == "music3"){

					Debug.Log(colition2d.name);
					audio1.Stop();
					audio2.Stop();
					audio3.Play();

				}else if(colition2d == null){
					Debug.Log("Null");
				}
			}
		}
	}
}
