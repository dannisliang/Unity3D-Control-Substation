using UnityEngine;
using System.Collections;

public class button14 : MonoBehaviour {

	GameObject obj113;
	GameObject obj114;
	// Use this for initialization
	void Start () {
		obj114=  GameObject.Find ("114");
		obj114.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj113 = GameObject.Find ("113");
		if (obj113) {
			if (!obj113.animation.isPlaying) {
		
				obj114.SetActive (true);
				obj114.GetComponent<Animation> ().enabled = true;
				obj114.GetComponent<AudioSource> ().enabled = true;
				rotazuo.w=20;
				GameObject.Find("GameObject").GetComponent<rotazuo>().enabled=true;
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
