using UnityEngine;
using System.Collections;

public class zhuanyi2 : MonoBehaviour {

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnClick ()
	{	
		int n = Random.Range (1, 3);
		string s;
		s = n.ToString ();

		kong.LoadName=s;
		GameObject.Find("GameObject").GetComponent<Loading> ().enabled = true;
		GameObject.Find ("pro").GetComponent<jindutiao> ().enabled = true;
		GameObject.Find ("Camera").SetActive (false);
	}
}
