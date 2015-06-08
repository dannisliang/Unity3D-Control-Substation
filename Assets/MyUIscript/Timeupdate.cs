using UnityEngine;
using System.Collections;

public class Timeupdate : MonoBehaviour {
	public UILabel lb;
	public string time;
	protected int n;
	// Use this for initialization
	void Start () {
		n = (int)Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {

		int min, ms;
		min = ((int)Time.time-n)/ 60;
		ms = ((int)Time.time-n) % 60;
		time = min.ToString () + ":" + ms.ToString ();
		//time = min.ToString () + "：" + ms.ToString ();
		lb.text = time;
	}
}
