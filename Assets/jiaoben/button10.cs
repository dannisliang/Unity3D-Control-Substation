using UnityEngine;
using System.Collections;

public class button10 : MonoBehaviour {
	GameObject obj109;
	GameObject obj110;
	// Use this for initialization
	void Start () {
		obj110=  GameObject.Find ("110");
		obj110.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj109 = GameObject.Find ("109");
		if (obj109) {
			if (!obj109.animation.isPlaying) {

				GameObject.Find("GameObject").GetComponent<rotazuo>().enabled = false;
				zuoshang.y=80;
				zuoshang.w=45;
				GameObject.Find("GameObject").GetComponent<zuoshang>().enabled=true;
				obj110.SetActive (true);
				obj110.GetComponent<Animation> ().enabled = true;
				obj110.GetComponent<AudioSource> ().enabled = true;
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
