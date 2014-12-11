using UnityEngine;
using System.Collections;

public class StartManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void WatchPicture(){

		Application.LoadLevel ("CategorySelect");

	}

	public void Explain(){
		Debug.Log ("Explain");
	}
}
