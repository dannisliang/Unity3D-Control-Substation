using UnityEngine;
using System.Collections;

public class button20 : MonoBehaviour {

	GameObject obj119;
	GameObject obj120;
	// Use this for initialization
	void Start () {
		obj120=  GameObject.Find ("120");
		obj120.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj119 = GameObject.Find ("119");
		if (obj119) {
			if (!obj119.animation.isPlaying) {

				rotashang.w=40;
				zidongcamera.w=-10;
				zidongcamera.x=0.25f;
				GameObject.Find("GameObject").GetComponent<rotashang>().enabled = true;

				obj120.SetActive (true);
				obj120.GetComponent<Animation> ().enabled = true;
				obj120.GetComponent<AudioSource> ().enabled = true;
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
