using UnityEngine;
using System.Collections;

public class button3 : MonoBehaviour {

	GameObject obj102;
	GameObject obj103;
	// Use this for initialization
	void Start () {
		obj103=  GameObject.Find ("103");
		obj103.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj102 = GameObject.Find ("102");
		if (obj102) {
			if (!obj102.animation.isPlaying) {
				obj103.SetActive (true);
				obj103.GetComponent<Animation> ().enabled = true;
				obj103.GetComponent<AudioSource> ().enabled = true;
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
