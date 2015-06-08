using UnityEngine;
using System.Collections;

public class button22 : MonoBehaviour {

	GameObject obj121;
	GameObject obj122;
	// Use this for initialization
	void Start () {
		obj122=  GameObject.Find ("122");
		obj122.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj121 = GameObject.Find ("121");
		if (obj121) {
			if (!obj121.animation.isPlaying) {
				shangzuo.y=30;
				shangzuo.w=45;
				GameObject.Find("GameObject").GetComponent<shangzuo>().enabled = true;
				obj122.SetActive (true);
				obj122.GetComponent<Animation> ().enabled = true;	
				obj122.GetComponent<AudioSource> ().enabled = true;
		
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
