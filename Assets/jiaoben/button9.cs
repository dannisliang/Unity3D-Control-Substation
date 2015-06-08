using UnityEngine;
using System.Collections;

public class button9 : MonoBehaviour {
	GameObject obj108;
	GameObject obj109;
	// Use this for initialization
	void Start () {
		obj109=  GameObject.Find ("109");
		obj109.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj108 = GameObject.Find ("108");
		if (obj108) {
			if (!obj108.animation.isPlaying) {
				GameObject.Find("GameObject").GetComponent<zuoshzuo>().enabled =false ;
				obj109.SetActive (true);
				rotayou.w=20;
				GameObject.Find("GameObject").GetComponent<rotayou>().enabled = true;
				obj109.GetComponent<Animation> ().enabled = true;	
				obj109.GetComponent<AudioSource> ().enabled = true;
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
