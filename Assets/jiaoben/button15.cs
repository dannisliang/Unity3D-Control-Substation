using UnityEngine;
using System.Collections;

public class button15 : MonoBehaviour {

	GameObject obj114;
	GameObject obj115;
	// Use this for initialization
	void Start () {
		obj115=  GameObject.Find ("115");
		obj115.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj114 = GameObject.Find ("114");
		if (obj114) {
			if (!obj114.animation.isPlaying) {
				GameObject.Find("GameObject").GetComponent<zuo180>().enabled = false;
				GameObject.Find("GameObject").GetComponent<rotazuo>().enabled=false;
				zuo180.w=180;
				rotazuo.w=60;

				GameObject.Find("GameObject").GetComponent<rotazuo>().enabled=true;
				obj115.SetActive (true);
			obj115.GetComponent<Animation> ().enabled = true;
				obj115.GetComponent<AudioSource> ().enabled = true;
				yincang.fun();
				yincang.funny();
				Destroy (this.transform.gameObject);
			} else {
				yincang.funny2();
			}
		}
		else {
			yincang.fun2();
			yincang.Add();
		}
		
	}
}
