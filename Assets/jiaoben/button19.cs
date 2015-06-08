using UnityEngine;
using System.Collections;

public class button19 : MonoBehaviour {

	GameObject obj118;
	GameObject obj119;
	// Use this for initialization
	void Start () {
		obj119=  GameObject.Find ("119");
		obj119.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj118 = GameObject.Find ("118");
		if (obj118) {
			if (!obj118.animation.isPlaying) {
			//	GameObject.Find("gameobject").GetComponent<moveg>().enabled=false;
				obj119.SetActive (true);
				zidongcamera.w=15;
				zidongcamera.x=0.5f;
				rotadown.w=20;
				GameObject.Find("GameObject").GetComponent<rotadown>().enabled = true;
				obj119.GetComponent<Animation> ().enabled = true;	
				obj119.GetComponent<AudioSource> ().enabled = true;
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
