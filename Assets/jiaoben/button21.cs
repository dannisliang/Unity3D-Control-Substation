using UnityEngine;
using System.Collections;

public class button21 : MonoBehaviour {

	GameObject obj120;
	GameObject obj121;
	// Use this for initialization
	void Start () {
		obj121=  GameObject.Find ("121");
		obj121.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj120 = GameObject.Find ("120");
		if (obj120) {
			if (!obj120.animation.isPlaying) {
				obj121.SetActive (true);
				obj121.GetComponent<Animation> ().enabled = true;	
				obj121.GetComponent<AudioSource> ().enabled = true;
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
