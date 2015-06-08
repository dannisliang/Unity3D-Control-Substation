using UnityEngine;
using System.Collections;

public class fenshu : MonoBehaviour {
	public UILabel lb;
	string fen;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		fen=yincang.count.ToString ();
		lb.text = fen;
	}
}
