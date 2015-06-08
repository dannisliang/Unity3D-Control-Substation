using UnityEngine;
using System.Collections;

public class button4 : MonoBehaviour {
	GameObject obj103;
	GameObject obj104;
	// Use this for initialization
	void Start () {
		obj104=  GameObject.Find ("104");
		obj104.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj103 = GameObject.Find ("103");
		if (obj103) {
			if (!obj103.animation.isPlaying) {
				rotashang.w=20;
				GameObject.Find("GameObject").GetComponent<rotashang>().enabled = true;
				obj104.SetActive (true);
				obj104.GetComponent<Animation> ().enabled = true;	
				obj104.GetComponent<AudioSource> ().enabled = true;
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
