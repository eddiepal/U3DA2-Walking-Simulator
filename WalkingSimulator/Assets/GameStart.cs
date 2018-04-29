using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour {

	public GameObject skulls;
	public GameObject fences;
	public GameObject terrain;
	// Use this for initialization
	void Start () {
		skulls.SetActive (true);
		fences.SetActive (true);
		terrain.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
