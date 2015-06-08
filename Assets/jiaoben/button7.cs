using UnityEngine;
using System.Collections;

public class button7 : MonoBehaviour {
	GameObject obj106;
	GameObject obj107;

	// Use this for initialization
	void Start () {
		obj107=  GameObject.Find ("107");
		obj107.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj106 = GameObject.Find ("106");
		if (obj106) {
			if (!obj106.animation.isPlaying) {
				GameObject.Find("GameObject").GetComponent<youshang>().enabled = false;
				downzuo.y=45;
				downzuo.w=150;
				GameObject.Find("GameObject").GetComponent<downzuo>().enabled = true;
				zidongcamera.w=-7;
				zidongcamera.x=0.25f;
			
				obj107.SetActive (true);
				obj107.GetComponent<Animation> ().enabled = true;
				obj107.GetComponent<AudioSource> ().enabled = true;
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
