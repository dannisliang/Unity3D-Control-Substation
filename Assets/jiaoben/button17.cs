using UnityEngine;
using System.Collections;

public class button17 : MonoBehaviour {
	GameObject obj101;
	GameObject obj102;
	GameObject obj103;
	GameObject obj104;
	GameObject obj105;
	GameObject obj106;
	GameObject obj107;
	GameObject obj108;
	GameObject obj109;
	GameObject obj110;
	GameObject obj111;
	GameObject obj112;
	GameObject obj113;
	GameObject obj114;
	GameObject obj115;
	GameObject obj116;
	GameObject obj117;
	// Use this for initialization
	void Start () {

	
		obj117=  GameObject.Find ("117");
		obj117.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
	
		obj113=GameObject.Find("113");
		obj114=GameObject.Find("114");
		obj115=GameObject.Find("115");
		obj116=GameObject.Find("116");
		if (obj116) {
			if (!obj116.animation.isPlaying) {
		
				obj113.SetActive (false);
				obj114.SetActive (false);
				obj115.SetActive (false);
				obj116.SetActive (false);
				//movecyou.w=60;
				movecyou.y=60;
				movecyou.w=20;

				GameObject.Find("GameObject").GetComponent<movecyou>().enabled = true;
				zidongcamera.w=17;
				zidongcamera.x=1f;
				GameObject.Find("GameObject2").GetComponent<movec>().enabled = true;
				obj117.SetActive (true);
				obj117.GetComponent<Animation> ().enabled = true;	
				obj117.GetComponent<AudioSource> ().enabled = true;
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
