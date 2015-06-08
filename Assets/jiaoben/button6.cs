using UnityEngine;
using System.Collections;

public class button6 : MonoBehaviour {
	GameObject obj105;
	GameObject obj106;
	// Use this for initialization
	void Start () {
		obj106=  GameObject.Find ("106");
		obj106.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj105 = GameObject.Find ("105");
		if (obj105) {
			if (!obj105.animation.isPlaying) {
				GameObject.Find("GameObject").GetComponent<downyou>().enabled = false;
				youshang.w=45;
				youshang.y=120;
				GameObject.Find("GameObject").GetComponent<youshang>().enabled = true;
				obj106.SetActive (true);
				obj106.GetComponent<Animation> ().enabled = true;
				obj106.GetComponent<AudioSource> ().enabled = true;
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
