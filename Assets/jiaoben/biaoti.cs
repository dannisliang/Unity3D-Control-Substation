using UnityEngine;
using System.Collections;

public class biaoti: MonoBehaviour {
	public UILabel lb;
	string biao;
	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update () {
		biao = "error";
		lb.text = biao;
	}
}