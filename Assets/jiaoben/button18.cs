using UnityEngine;
using System.Collections;

public class button18 : MonoBehaviour {

	GameObject obj117;
	GameObject obj118;
	// Use this for initialization
	void Start () {
		obj118=  GameObject.Find ("118");
		obj118.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj117 = GameObject.Find ("117");
		if (obj117) {
			if (!obj117.animation.isPlaying) {
				GameObject.Find("GameObject").GetComponent<movecyou>().enabled = false;
				GameObject.Find("GameObject2").GetComponent<movec>().enabled = false;
				//GameObject.Find("gameobject").GetComponent<moveg>().enabled=true;
				obj118.SetActive (true);
				obj118.GetComponent<Animation> ().enabled = true;	
				obj118.GetComponent<AudioSource> ().enabled = true;
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
