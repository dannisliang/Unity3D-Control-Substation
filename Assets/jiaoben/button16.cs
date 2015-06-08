using UnityEngine;
using System.Collections;

public class button16 : MonoBehaviour {

	GameObject obj115;
	GameObject obj116;
	// Use this for initialization
	void Start () {
		obj116=  GameObject.Find ("116");
		obj116.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj115 = GameObject.Find ("115");
		if (obj115) {
			if (!obj115.animation.isPlaying) {
				obj116.SetActive (true);
				obj116.GetComponent<Animation> ().enabled = true;
				obj116.GetComponent<AudioSource> ().enabled = true;
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
