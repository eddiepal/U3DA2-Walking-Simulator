using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChnageSkybox : MonoBehaviour {
	public Material Skybox2;
	public GameObject elephants;
	public GameObject trees;

	//var mat2:Material;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		//RenderSettings.skybox=Skybox2;
		elephants.SetActive (false);
		trees.SetActive (false);

	}
}
