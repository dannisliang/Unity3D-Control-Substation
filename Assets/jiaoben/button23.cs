using UnityEngine;
using System.Collections;

public class button23 : MonoBehaviour {
	GameObject obj122;
	GameObject obj123;
	// Use this for initialization
	void Start () {
		obj123=  GameObject.Find ("123");
		obj123.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj122 = GameObject.Find ("122");
		if (obj122) {
			if (!obj122.animation.isPlaying) {
				rotazuo.v=80;
				rotazuo.w=135;
				GameObject.Find("GameObject").GetComponent<rotazuo>().enabled = true;
				obj123.SetActive (true);
				obj123.GetComponent<Animation> ().enabled = true;	
				obj123.GetComponent<AudioSource> ().enabled = true;
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
