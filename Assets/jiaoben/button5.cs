using UnityEngine;
using System.Collections;

public class button5 : MonoBehaviour {
	GameObject obj104;
	GameObject obj105;
	// Use this for initialization
	void Start () {
		obj105=  GameObject.Find ("105");
		obj105.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj104 = GameObject.Find ("104");
		if (obj104) {
			if (!obj104.animation.isPlaying) {
				downyou.w=60;
				downyou.y=65;
				GameObject.Find("GameObject").GetComponent<rotashang>().enabled = false;
				GameObject.Find("GameObject").GetComponent<downyou>().enabled = true;
				obj105.SetActive (true);
				obj105.GetComponent<Animation> ().enabled = true;	
				obj105.GetComponent<AudioSource> ().enabled = true;
				yincang.fun();
				yincang.funny();
				Destroy (this.transform.gameObject);
			} else {		yincang.funny2();
			}
		}
		else {
			yincang.fun2();
			yincang.Add();
		}
		
	}
}
