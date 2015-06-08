using UnityEngine;
using System.Collections;

public class jinyong : MonoBehaviour {
	 public static GameObject  caca;

	// Use this for initialization
	void Awake () {
		caca=GameObject.Find("CameraJDT");
		caca.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {


	}
}
