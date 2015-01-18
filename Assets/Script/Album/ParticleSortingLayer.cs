using UnityEngine;
using System.Collections;

public class ParticleSortingLayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Set the sorting layer of the particle system.
		particleSystem.renderer.sortingLayerName = "foreground";

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
