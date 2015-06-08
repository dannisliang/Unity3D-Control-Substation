using UnityEngine;
using System.Collections;

public class button11 : MonoBehaviour {
	GameObject obj110;
	GameObject obj111;
	// Use this for initialization
	void Start () {
		obj111=  GameObject.Find ("111");
		obj111.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj110 = GameObject.Find ("110");
		if (obj110) {
			if (!obj110.animation.isPlaying) {
			
				GameObject.Find("GameObject").GetComponent<rotadown>().enabled=false;
				rotashang.w=40;
				GameObject.Find("GameObject").GetComponent<rotashang>().enabled=true;
				obj111.SetActive (true);
				obj111.GetComponent<Animation> ().enabled = true;	
				obj111.GetComponent<AudioSource> ().enabled = true;
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
