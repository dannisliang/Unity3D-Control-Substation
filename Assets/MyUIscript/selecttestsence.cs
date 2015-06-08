using UnityEngine;
using System.Collections;

public class selecttestsence : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnClick () {

		int n = Random.Range (1, 3);
		string s;
		s = n.ToString ();
		Application.LoadLevel (s);
		}
}
