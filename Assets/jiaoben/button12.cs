using UnityEngine;
using System.Collections;

public class button12 : MonoBehaviour {
	GameObject obj111;
	GameObject obj112;
	// Use this for initialization
	void Start () {
		obj112=  GameObject.Find ("112");
		obj112.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj111 = GameObject.Find ("111");
		if (obj111) {
			if (!obj111.animation.isPlaying) {
				obj112.SetActive (true);
				obj112.GetComponent<Animation> ().enabled = true;	
				obj112.GetComponent<AudioSource> ().enabled = true;
				GameObject.Find("GameObject").GetComponent<rotashang>().enabled=false;
				rotayou.w=70;
				GameObject.Find("GameObject").GetComponent<rotayou>().enabled=true;
				zuo180.v=80;
				zuo180.w=230;
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
