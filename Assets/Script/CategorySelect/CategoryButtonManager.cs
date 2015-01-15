using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CategoryButtonManager : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CSAll(){
		Debug.Log ("CSAll");
		Application.LoadLevel ("Album");
	}

	public void CSForMen(){
		Debug.Log ("CSForMen");
		Application.LoadLevel ("AlbumForMen");
	}

	public void CSForWomen(){
		Debug.Log ("CSForWomen");
		Application.LoadLevel ("AlbumForWomen");
	}
	public void CS60(){
		Debug.Log ("60");
		Application.LoadLevel ("Album");
	}

	public void CS70(){
		Debug.Log ("70");
		Application.LoadLevel ("Album");
	}

	public void CS80(){
		Debug.Log ("80");
		Application.LoadLevel ("Album");
	}

	public void CSHome(){
		Resources.UnloadUnusedAssets();
		Debug.Log("Home");
		Application.LoadLevel ("StartScene");
	}
}
