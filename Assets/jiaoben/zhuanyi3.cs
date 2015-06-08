using UnityEngine;
using System.Collections;

public class zhuanyi3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnClick ()
	{	kong.LoadName="Helpsence";
		GameObject.Find("GameObject").GetComponent<Loading> ().enabled = true;
		GameObject.Find ("pro").GetComponent<jindutiao> ().enabled = true;
		GameObject.Find ("Camera").SetActive (false);
	}
}
