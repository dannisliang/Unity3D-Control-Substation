using UnityEngine;
using System.Collections;

public class button8 : MonoBehaviour {
	GameObject obj107;
	GameObject obj108;
	// Use this for initialization
	void Start () {
		obj108=  GameObject.Find ("108");
		obj108.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnClick () {
		obj107 = GameObject.Find ("107");
		if (obj107) {
			if (!obj107.animation.isPlaying) {
				GameObject.Find("GameObject").GetComponent<downzuo>().enabled = false;

				zuoshzuo.y=30;
				zuoshzuo.w=5;
				zuoshzuo.z=120;
				GameObject.Find("GameObject").GetComponent<zuoshzuo>().enabled =true ;

				obj108.SetActive (true);
				obj108.GetComponent<Animation> ().enabled = true;
				obj108.GetComponent<AudioSource> ().enabled = true;
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
