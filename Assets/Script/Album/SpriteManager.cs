using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public struct ImageBoard {
	private int id;
	private string name;

	public void setName(string name) {
		this.name = name;
	}

	public ImageBoard(int id, string name) {
		this.id = id;
		this.name = name;

		//this.aaa = new AAA ();
	}

	/*public ~ImageBoard() {
		delete this.aaa;
	}*/

}

public class SpriteManager : MonoBehaviour {
	public GameObject[] imageBoards;

	private const int NUM_LIST = 3;
	//public ImageBoard[] imageBoards = new ImageBoard[NUM_LIST];

	private int currentID = 0;

	// Use this for initialization
	void Start () {
		List<ImageBoard> _imageBoards = new List<ImageBoard>();

		for (int i = 0; i < NUM_LIST; i++) {
			ImageBoard ib = new ImageBoard( 0, "Otsuki" );
			//this.imageBoards.Add(ib);
		}
	}
	
	// Update is called once per frame
	void Update () {

		//this.imageBoards.RemoveAt (0);
	}
}
