using UnityEngine;
using System.Collections;

public class SortingLayer_particle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Set the sorting layer of the particle system.
		particleSystem.renderer.sortingLayerName = "foreground";

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
